# InterviewAnswers
## Requirements
The program needs to read in a list of integers (e.g. 10 20 30 40 5 2 7)
Ask the user for a list of algorithms to use to process them (e.g. min max mean first last)
Then print the results.

## Notes
All the logic of the algorithms is located in different classes, connected to the Algorithm Factory. The way it´s organized, it allows for the addition of new algorithms without the need to add any new code to the 'Program.cs'.
The algorithms use the interface 'IAlgorithms' to use the function Calculate. After this, each class implements it´s own algorithm.
The abstract class FirstNumber is used to share the function 'GetFirst' which calculates the first number in the List of integers the user inputs. This wasn´t neede, as it could have been easily solved with Linq, but more complex algorithms could have benefited from this type of structure.

It won´t accept incorrect integers, and will ask again from new input.
It won´t accept incorrect algorithm names, and it will show in the console the algorithms that it won´t run.
