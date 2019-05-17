# Object-Oriented-Programming
Unique Paint

## Task 1:
*"Introduction to the concepts of OOP: inheritance and polymorphism of types (virtual methods)"*  

*Build a class hierarchy for displaying graphic shapes: a segment, a rectangle, an ellipse, and so on - at least 6 shapes. Distribute classes by module. Create a list of shapes as a separate class. In the main module of the program add different figures to the list (static initialization), then start drawing a list of figures. For drawing use any suitable graphic library.*

## Task 2:
*"Graphic Editor"*

*Extend the example with graphic shapes so that shapes can be created at the user interface level. There are several ways: input of coordinates using the mouse, interactive input of values, input in the scripting language. The student can choose any input method. Creating an object should be done in such a way that adding a new class to the system does not require changing the existing code (the choice of type using the case / switch operator and multiple if cannot be done). The resulting program should be a primitive graphics editor. The shape classes should not contain a drawing method.*

## Task 3:
*"Serialization of objects"*

*Select a subject area and build a class hierarchy. The hierarchy must include at least 6 classes.
To implement serialization / deserialization of objects from the resulting class hierarchy to / from a file, the serialization format is determined by the individual variant.
In the user interface, you must implement the following functions:*
* *Serialization / deserialization of the list of objects.*

*Data Structure according to the variant: JSON.*  
*Adding new classes to the hierarchy should not lead to the need to rewrite existing code, and not to use if-else / switch-case, reflection.
Optional: implementation graphical interface.*

## Task 4:
*"Plugins - hierarchy"*

*Based on 2 or 3 tasks, expand the existing hierarchy with new classes using dynamic module loading (plug-in). New modules should add or expand the functionality of the basic program: a new class in the hierarchy, functions for working with it, new elements in the user interface for working with a new class.
You can load modules from the folder or via the parameter string in the main module with the name of the new module and possible recompilation. Ideally, adding a new module should be performed by its dynamic loading, i.e. should not require changing the program code at all.*

## Task 6:

*Extend the designed application with the ability to configure operation parameters.
Add the ability to load and save configuration work.
Configuration options to choose in accordance with your application, for example - background color, language, format of saved files, enable / disable menu with information, various settings
The configuration must be read from the XML file and saved to it. The structure of the XML file to develop independently. Add correct error handling.*
