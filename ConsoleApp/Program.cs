using System;
using System.Collections.Generic;

namespace Challenge1.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            var shapes = new List<Shape>();

            while(true) {
                Console.WriteLine("1: Create Square");
                Console.WriteLine("2: Create Rectangle");
                Console.WriteLine("3: View Shape");
                Console.WriteLine("4: Exit");

                while(true) {
                    Console.Write("Choose menu entry: ");

                    var selectionText = Console.ReadLine();

                    int selection;
                    try {
                        selection = int.Parse(selectionText);
                    } catch(FormatException) {
                        Console.WriteLine("Please enter a number");

                        continue;
                    }

                    switch(selection) {
                        case 1: {
                            Console.Write("Enter colour: ");

                            var colour = Console.ReadLine();

                            var side1Length = RetrieveLength("side");

                            shapes.Add(new Square(colour, side1Length));

                            Console.WriteLine("Successfully created Square");
                        } break;

                        case 2: {
                            Console.Write("Enter colour: ");

                            var colour = Console.ReadLine();

                            var side1Length = RetrieveLength("side 1");

                            var side2Length = RetrieveLength("side 2");

                            shapes.Add(new Rectangle(colour, side1Length, side2Length));

                            Console.WriteLine("Successfully created Rectangle");
                        } break;

                        case 3: {
                            if(shapes.Count == 0) {
                                Console.WriteLine("There are no shapes to view");
                            } else {
                                for(var i = 0; i < shapes.Count; i += 1) {
                                    Console.WriteLine($"{i + 1}: {shapes[i].GetType().Name}");
                                }

                                int shapeIndex;
                                while(true) {
                                    Console.Write("Choose shape: ");

                                    var shapeIndexText = Console.ReadLine();

                                    try {
                                        shapeIndex = int.Parse(shapeIndexText);
                                    } catch(FormatException) {
                                        Console.WriteLine("Please enter a number");

                                        continue;
                                    }

                                    if(shapeIndex < 1 || shapeIndex > shapes.Count) {
                                        Console.WriteLine($"No shape {shapeIndex}");

                                        continue;
                                    }

                                    break;
                                }

                                var shape = shapes[shapeIndex - 1];

                                switch(shape) {
                                    case Square square: {
                                        Console.WriteLine($"Side length: {square.Side1Length}");
                                        Console.WriteLine($"Colour: {square.Colour}");

                                        Console.WriteLine($"Area: {square.GetArea()}");
                                        Console.WriteLine($"Perimeter: {square.GetPerimeter()}");
                                    } break;

                                    case Rectangle rectangle: {
                                        Console.WriteLine($"Side 1 length: {rectangle.Side1Length}");
                                        Console.WriteLine($"Side 2 length: {rectangle.Side2Length}");
                                        Console.WriteLine($"Colour: {rectangle.Colour}");

                                        Console.WriteLine($"Area: {rectangle.GetArea()}");
                                        Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");
                                    } break;

                                    case Quadrilateral quadrilateral: {
                                        Console.WriteLine($"Side 1 length: {quadrilateral.Side1Length}");
                                        Console.WriteLine($"Side 2 length: {quadrilateral.Side2Length}");
                                        Console.WriteLine($"Side 3 length: {quadrilateral.Side3Length}");
                                        Console.WriteLine($"Side 4 length: {quadrilateral.Side4Length}");
                                        Console.WriteLine($"Colour: {quadrilateral.Colour}");

                                        Console.WriteLine($"Perimeter: {quadrilateral.GetPerimeter()}");
                                    } break;

                                    default: {
                                        Console.WriteLine($"Colour: {shape.Colour}");
                                    } break;
                                }
                            }
                        } break;

                        case 4: {
                            return;
                        } break;

                        default: {
                            Console.WriteLine($"No menu item {selection}");

                            continue;
                        } break;
                    }

                    break;
                }
            }
        }

        public static int RetrieveLength(string name) {
            while(true) {
                Console.Write($"Enter {name} length: ");

                var lengthText = Console.ReadLine();

                try {
                    var length = int.Parse(lengthText);

                    if(length < 0) {
                        throw new NegativeLengthException();
                    }

                    return length;
                } catch(FormatException) {
                    Console.WriteLine("Please enter an integer");

                    continue;
                } catch(NegativeLengthException) {
                    Console.WriteLine("Length must be positive ");

                    continue;
                }
            }
        }
    }
}