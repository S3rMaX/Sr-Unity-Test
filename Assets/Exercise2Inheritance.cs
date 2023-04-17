using OpenCover.Framework.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using Unity.VisualScripting;
using UnityEditor.Presets;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Exercise2Inheritance : MonoBehaviour
{
    /**
     * 
    Inheritance in C# allows a class to inherit properties, methods, and other members from another class, 
        called the base class or parent class. The class that inherits these members is called the derived class 
        or child class.

To create a derived class, the : character is used, followed by the name of the base class. For example:


class DerivedClass : BaseClass
    {
        // members of the derived class
    }


    The derived class can access the members of the base class, including public and protected members, 
    as if they were defined in the derived class itself. Private members of the base class cannot be accessed 
    by the derived class.

There are several keywords and restrictions that apply to inheritance in C#:

base: This keyword is used to access members of the base class from the derived class. For example, 
    base.Method() calls the Method method defined in the base class.

virtual: This keyword is used to indicate that a method or property in the base class can be overridden in a derived class.

override: This keyword is used in the derived class to override a virtual method or property in the base class.

sealed: This keyword is used to prevent a derived class from overriding a virtual method or property in the base class.

abstract: This keyword is used to define a class or member as abstract, which means it must be implemented in a derived class.

Multiple inheritance is not allowed in C#.

A derived class constructor must call the base class constructor using the base keyword or an implicit call 
    to the parameterless constructor of the base class is made.

Access modifiers such as public, protected, private, internal can be used in inheritance to restrict 
    or allow access to members of the base class in the derived class.

In summary, inheritance in C# allows for code reuse and creating more specialized classes from a base class. 
    By using the appropriate keywords and adhering to the restrictions, developers can create a hierarchy of related classes that can be used to build complex applications.

    **/
}
