import cv2
import mediapipe as mp
import time

mp_drawing = mp.solutions.drawing_utils
mp_drawing_styles = mp.solutions.drawing_styles
mp_hands = mp.solutions.hands

def hand_gesture_detection_and_save():
    timeout =5
    file_path="predictions.txt"
    cap = cv2.VideoCapture(0)
    with mp_hands.Hands(
        model_complexity=0,
        min_detection_confidence=0.9,
        min_tracking_confidence=0.9) as hands:

        start_time = time.time()

        while (time.time() - start_time) <= timeout:
            success, image = cap.read()
            if not success:
                print("Ignoring empty camera frame.")
                continue

            image.flags.writeable = False
            image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)
            results = hands.process(image)

            image.flags.writeable = True
            image = cv2.cvtColor(image, cv2.COLOR_RGB2BGR)

            fingerCount = 0

            if results.multi_hand_landmarks:

                for hand_landmarks in results.multi_hand_landmarks:
                    handIndex = results.multi_hand_landmarks.index(hand_landmarks)
                    handLabel = results.multi_handedness[handIndex].classification[0].label

                    handLandmarks = []

                    for landmarks in hand_landmarks.landmark:
                        handLandmarks.append([landmarks.x, landmarks.y])

                    if handLabel == "Left" and handLandmarks[4][0] > handLandmarks[3][0]:
                        fingerCount = fingerCount+1
                    elif handLabel == "Right" and handLandmarks[4][0] < handLandmarks[3][0]:
                        fingerCount = fingerCount+1

                    if handLandmarks[8][1] < handLandmarks[6][1]:       #Index finger
                        fingerCount = fingerCount+1
                    if handLandmarks[12][1] < handLandmarks[10][1]:     #Middle finger
                        fingerCount = fingerCount+1
                    if handLandmarks[16][1] < handLandmarks[14][1]:     #Ring finger
                        fingerCount = fingerCount+1
                    if handLandmarks[20][1] < handLandmarks[18][1]:     #Pinky
                        fingerCount = fingerCount+1

                    mp_drawing.draw_landmarks(
                        image,
                        hand_landmarks,
                        mp_hands.HAND_CONNECTIONS,
                        mp_drawing_styles.get_default_hand_landmarks_style(),
                        mp_drawing_styles.get_default_hand_connections_style())

            # Display countdown on the screen
            remaining_time = int(timeout - (time.time() - start_time))
            cv2.putText(image, f"Countdown: {remaining_time}", (50, 50), cv2.FONT_HERSHEY_SIMPLEX, 1, (255, 255, 255), 2)
            cv2.putText(image, f"Number: {str(fingerCount)}", (50, 450), cv2.FONT_HERSHEY_SIMPLEX, 3, (255, 0, 0), 10)
            cv2.imshow('MediaPipe Hands', image)
            if cv2.waitKey(5) & 0xFF == 27:
                break

        cap.release()
        cv2.destroyAllWindows()

        # Save the prediction to a text file
        with open(file_path, 'w') as f:
            f.write(str(fingerCount))