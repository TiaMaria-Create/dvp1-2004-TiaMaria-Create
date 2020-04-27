
## PROJECT AND PORTFOLIO I: DEVELOPMENT ONLINE

* **Developing a Solution**
* **TYKEEJA HARRIS**
* **4/23/2020**

This research paper summarizes my time and effort looking into the topic matter outlined below. I have included links and references to research information used for this activity.    

## Topic: Diagram a Process
There are certain techniques used in the industry that can help a developer think through and diagram a logical process. After research into this topic, here's what I have learned...  

**1. UML Stands for...**

UML stands for Unified Modeling Langueage. UML is a way of visualizing a software program using a collection of diagrams. ("UML Diagram - Everything You Need to Know About UML Diagrams", 2020)


**2. Common Symbols used in UML include...**.

* **Beginning Node**: Every activity diagram shall have one initial node. This is the entry point of the process. The symbol for the inital node is a Solid Circle
* **Final Node**: Every actitivity diagram has at least one final node. The symbol for the final node is a Solid Circle w/ an Outline.
* **Decision**: The decision symbol shows a split in actions based on a condition. Think of decisons as yes or no questions. Each condition should clearly state the decison.
* **Process**: This symbol represents the start of each process that makes up an application. The symbol has a description that represents the process.
* **Action**: The action symbol contains the action being performed. Actions should be short and simple and include a verb.
* **Control Flow**: The control flow shows the direction of the process. The symbol is a stright arrow pointing in the direction of the flow.


**3. An action in a UML diagram is usually followed by...**

The action symbol in a UML diagram contains the action being performed. Actions are connected by control flows the show the order of operations. Actions should be short and simple and include a verb.
 
**4. An action is a verb, something that takes place. Write a line of code that can represent an action that occurs after a decision point in a program (think of an if/else statement).**

``` C#

if (cartItems < 10)
{
shippingTotal = (cartItems * 1.25m);
}
else
shippingTotal = (cartItems * 1.15m);
}

```

**5. How many actions are in this statement? "Open the container, pour the fudge, and close the container.**
 
The above action contains three actions, as each action contains a verb. The word "and" also indicates there is more than one action.



## Topic: Document a Process
There are certain techniques used in the industry that can help a developer think through and document a logical process. After research into this topic, here's what I have learned...   

**1. What is an algorithm?**

An algorithm is a set of instructions used to solve a particular problem. In computing, programmers write algorithms that instruct the computer how to perform a task ("How to Explain Algorithms to Kids | Tynker Blog", 2020). An algorithm can be presented using Psuedo code or a flowchart.

E X A M P L E

_-Algorithm to find the greatest among three numbers-_


**ALGORITHM 1.**

``` 

Step 1: Start

Step 2: Read the three numbers A, B, C

Step 3: Compare A and B. If A is greater perform step 4 else perform step 5.

Step 4: Compare A and C. If A is greater, output “A is greatest” else output “C is greatest”. Perform step 6.

Step 5: Compare B and C. If B is greater, output “B is greatest” else output “C is greatest”.

Step 6: Stop 

``` 


**2. Is there one way to write pseudo-code?**

There is no standard syntax for writing psuedo code.(Goel, 2010)

**3. Provide an example of a simple control-structure used in C#.**

``` 

//Start the loop

            while (donuts > 0)
            {

                Console.WriteLine("There are {0} donuts left in the box", donuts);

                //Ask the coworkers how many donuts they would like
                Console.WriteLine("Ask a co-worker how many donuts they would like.");
                //Declare and define a donut quantity variable by storing the users response
                string userPick = Console.ReadLine();

                //Declare a number data type to store the users repsonse
                int share;


                while (!(int.TryParse(userPick, out share)) || (share < 0 || share > 3))
                {
                    //Tell the user the problem
                    Console.WriteLine("Please enter a valid amount. Don't take more than three donuts per person.");
                    //Restate the question
                    Console.WriteLine("How many donuts?");
                    //catch the response
                    userPick = Console.ReadLine();

                }

                //increment of change
                donuts -= share;

                //Nest conditional statement for when donuts are gone

                if (donuts < 0)
                {
                    //if there are no donuts and the user wants one, give them to them tomorrow
                    Console.WriteLine("The donuts are gone. I will give you {0} donuts tomorrow.", donuts*-1);

                }
                else if (donuts == 0)
                {
                    //if there are no dounuts and everyone has been served, let them enjoy.
                    Console.WriteLine("All of the donuts are gone. I hope everyone enjoyed them.");

                } 
```


# References

How to Explain Algorithms to Kids | Tynker Blog. (2020). Retrieved 22 March 2020, Retrieved from https://www.tynker.com/blog/articles/ideas-and-tips/how-to-explain-algorithms-to-kids/

UML Diagram - Everything You Need to Know About UML Diagrams. (2020). Retrieved 22 March 2020, Retrieved from https://www.smartdraw.com/uml-diagram/#whatIsUML

Goel, A. (2010). Computer Fundamentals (p. 55-59). Pearson India.
