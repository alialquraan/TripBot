using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace TravelRecommendationRobot
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.Testing.API.ITestingService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace TravelRecommendationRobot.ObjectRepository
{
    public static class Descriptors
    {
        public static class Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations
        {
            public static _Implementation._Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations.__Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations { get; private set; } = new _Implementation._Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations.__Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations();
        }

        public static class Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia
        {
            public static _Implementation._Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia.__Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia { get; private set; } = new _Implementation._Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia.__Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia();
        }
    }
}

namespace TravelRecommendationRobot._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations._Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations
    {
        public class __JOD_236 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __JOD_236(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "zvDLkfmKnkW6khp1sq9DTg/eXwikQF9UUilM7EuVOCM5Q", DisplayName = "JOD 236", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations
    {
        public class __Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "zvDLkfmKnkW6khp1sq9DTg/f7AXYNo3o0yr3seqTcF-lA", DisplayName = "Edge: Booking.com | Official site | The best hotels, flights, car rentals & accommodations", Screen = this};
                JOD_236 = new _Implementation._Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations._Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations.__JOD_236(this, null);
            }

            public _Implementation._Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations._Edge__Booking_com___Official_site___The_best_hotels__flights__car_rentals___accommodations.__JOD_236 JOD_236 { get; private set; }
        }
    }

    namespace _Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia._Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia
    {
        public class __Adults : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Adults(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "zvDLkfmKnkW6khp1sq9DTg/hz6nhVY9J0mR7NUjcukPYg", DisplayName = "Adults", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia
    {
        public class __Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "zvDLkfmKnkW6khp1sq9DTg/k16VpTi6LUWQKoEY786nPg", DisplayName = "Edge: Cheap Flights, Plane Tickets & Airline Deals - Expedia", Screen = this};
                Adults = new _Implementation._Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia._Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia.__Adults(this, null);
            }

            public _Implementation._Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia._Edge__Cheap_Flights__Plane_Tickets___Airline_Deals___Expedia.__Adults Adults { get; private set; }
        }
    }
}