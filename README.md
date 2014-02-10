C# WPF Data Template and Content Presenter
======================

This project is an experiment on Data Templates.  I wanted a way to be able to completely change the content and layout of a view based on the type of the ViewModel.

For example, I have a computing or audio processing system that consists of Racks of equipment.  Inside each Rack are Boxes containing Cards.

I have a single window or view to display.  If the data context for the view is a Rack, I want to display a different color and Rack specific data, maybe the height and width.  If I want to display a Box in that window, I want a different color and then some Box specific data like what kind of role the Box fulfills in the solution, e.g., signal processing, audio input, etc.  If I want to display a Card, then, change to a different color and display Card data like the type of card, processor type, etc.

The reason on want something like this is this single window displays details about something selected in an external control, a navigation tree, for example.  Someone clicks on an item on the tree, and, I want to display the item details in this single window.  A person can click on a Rack or a Box or a Card.

