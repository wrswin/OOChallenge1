using System;
using System.Collections.Generic;

namespace Challenge1.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            var shapes = new List<Shape>();

            while(true) {
                Console.WriteLine("1: Create Square");
                Console.WriteLine("2: Create Rectangle");
                Console.WriteLine("3: Create RightAngleTriangle");
                Console.WriteLine("4: Create EquilateralTriangle");
                Console.WriteLine("5: View Shape");
                Console.WriteLine("6: Exit");

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

                            var side1Length = RetrieveIntegerLength("side");

                            shapes.Add(new Square(colour, side1Length));

                            Console.WriteLine("Successfully created Square");
                        } break;

                        case 2: {
                            Console.Write("Enter colour: ");

                            var colour = Console.ReadLine();

                            var side1Length = RetrieveIntegerLength("side 1");

                            var side2Length = RetrieveIntegerLength("side 2");

                            shapes.Add(new Rectangle(colour, side1Length, side2Length));

                            Console.WriteLine("Successfully created Rectangle");
                        } break;

                        case 3: {
                            Console.Write("Enter colour: ");

                            var colour = Console.ReadLine();

                            var side1Length = RetrieveFloatLength("side 1");

                            var side2Length = RetrieveFloatLength("side 2");

                            shapes.Add(new RightAngleTriangle(colour, side1Length, side2Length));

                            Console.WriteLine("Successfully created RightAngleTriangle");
                        } break;

                        case 4: {
                            Console.Write("Enter colour: ");

                            var colour = Console.ReadLine();

                            var side1Length = RetrieveFloatLength("side");

                            shapes.Add(new EquilateralTriangle(colour, side1Length));

                            Console.WriteLine("Successfully created EquilateralTriangle");
                        } break;

                        case 5: {
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
                                    case RightAngleTriangle rightAngleTriangle: {
                                        Console.WriteLine($"Side 1 length: {rightAngleTriangle.Side1Length}");
                                        Console.WriteLine($"Side 2 length: {rightAngleTriangle.Side2Length}");
                                        Console.WriteLine($"Side 3 length: {rightAngleTriangle.Side3Length}");
                                        Console.WriteLine($"Colour: {rightAngleTriangle.Colour}");

                                        Console.WriteLine($"Perimeter: {rightAngleTriangle.GetPerimeter()}");
                                        Console.WriteLine($"Area: {rightAngleTriangle.GetArea()}");
                                    } break;

                                    case EquilateralTriangle equilateralTriangle: {
                                        Console.WriteLine($"Side 1 length: {equilateralTriangle.Side1Length}");
                                        Console.WriteLine($"Colour: {equilateralTriangle.Colour}");

                                        Console.WriteLine($"Perimeter: {equilateralTriangle.GetPerimeter()}");
                                        Console.WriteLine($"Area: {equilateralTriangle.GetArea()}");
                                    } break;

                                    case Triangle triangle: {
                                        Console.WriteLine($"Side 1 length: {triangle.Side1Length}");
                                        Console.WriteLine($"Side 2 length: {triangle.Side2Length}");
                                        Console.WriteLine($"Side 3 length: {triangle.Side3Length}");
                                        Console.WriteLine($"Colour: {triangle.Colour}");

                                        Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}");
                                    } break;

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

                        case 6: {
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

        public static int RetrieveIntegerLength(string name) {
            while(true) {
                Console.Write($"Enter {name} length: ");

                var lengthText = Console.ReadLine();

                try {
                    var length = int.Parse(lengthText);

                    if(length < 1) {
                        throw new NonPositiveLengthException();
                    }

                    return length;
                } catch(FormatException) {
                    Console.WriteLine("Please enter an integer");

                    continue;
                } catch(NonPositiveLengthException) {
                    Console.WriteLine("Length must be positive");

                    continue;
                }
            }
        }

        public static float RetrieveFloatLength(string name) {
            while(true) {
                Console.Write($"Enter {name} length: ");

                var lengthText = Console.ReadLine();

                try {
                    var length = float.Parse(lengthText);

                    if((float)Math.Floor(length) != length) {
                        throw new DecimalLengthException();
                    }

                    if(length < 1) {
                        throw new NonPositiveLengthException();
                    }

                    return length;
                } catch(FormatException) {
                    Console.WriteLine("Please enter an integer");

                    continue;
                } catch(NonPositiveLengthException) {
                    Console.WriteLine("Length must be positive");

                    continue;
                } catch(DecimalLengthException) {
                    Console.WriteLine("Length must not be decimal");

                    continue;
                }
            }
        }
    }
}