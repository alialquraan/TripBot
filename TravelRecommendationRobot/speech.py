import speech_recognition as sr
from PIL import Image, ImageTk
import tkinter as tk
import threading
import time

def continuous_speech_to_text():
    def words_to_digits(text):
        word_to_digit = {
            'one': '1',
            'two': '2',
            'three': '3',
            'four': '4',
            'five': '5',
            'six': '6',
            'seven': '7',
            'eight': '8',
            'nine': '9',
            'zero': '0'
        }

        words = text.split()
        converted_text = ' '.join([word_to_digit[word] if word in word_to_digit else word for word in words])
        return converted_text

    def show_image_popup():
        popup = tk.Tk()
        popup.wm_title("Popup Image")

        image_path = 'OIP.jpeg'  # Replace with the actual path to your image
        image = Image.open(image_path)
        photo = ImageTk.PhotoImage(image)

        label = tk.Label(popup, image=photo)
        label.image = photo
        label.pack()

        countdown_label = tk.Label(popup, font=("Helvetica", 16))
        countdown_label.pack()

        def update_countdown(count):
            countdown_label.config(text=f"Time left: {count}")
            if count > 0:
                popup.after(1000, update_countdown, count - 1)
            else:
                popup.destroy()

        update_countdown(5)  # Start the countdown from 10 seconds

        popup.mainloop()

    recognizer = sr.Recognizer()

    show_image_thread = threading.Thread(target=show_image_popup)
    show_image_thread.start()

    with sr.Microphone() as source:
        recognizer.adjust_for_ambient_noise(source, duration=0.2)
        print("Listening for 10 seconds...")

        audio = recognizer.listen(source, timeout=5)

        try:
            text = recognizer.recognize_google(audio).lower()
            print(text)

            # Convert numbers from words to digits
            text = words_to_digits(text)

            # Save recognized text to listen.txt
            with open('listen.txt', 'w') as file:
                file.write(text + '\n')
        except sr.UnknownValueError:
            print("No speech detected within 10 seconds.")

    show_image_thread.join()  # Wait for the image thread to finish