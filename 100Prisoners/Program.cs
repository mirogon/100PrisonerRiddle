using _100Prisoners;

const int NUM_BOXES = 100;
if(NUM_BOXES%2 != 0) {
    Console.WriteLine("NUMBER OF BOXES HAS TO BE DIVISIBLE BY 2");
    Environment.Exit(-1);
}


int numTimesSolvedWithRandom = 0;
int numTimesSolvedWithCircle = 0;

int tries = 1000;

//Trying to solve the riddle 100 times with 100 prisoners
for(int i = 0; i < tries; ++i) {

    //Create a Prisoner Riddle with 100 Prisoners/Boxes
    RiddleSolver solver = new RiddleSolver(100);

    //Each of every Prisoner opens NUM_BOXES/2 random boxes to find their own number
    bool allFoundWithRandom = solver.SolveRandom();
    if (allFoundWithRandom) {
        ++numTimesSolvedWithRandom;
    }

    //Each of every Prisoner opens NUM_BOXES/2 boxes with the "circle algorithm" to find their own number
    bool allFoundWithCircle = solver.SolveCircle();
    if (allFoundWithCircle) {
        ++numTimesSolvedWithCircle;
    }
}

Console.WriteLine("Results to solve the Riddle:");
Console.WriteLine(((float)numTimesSolvedWithRandom/(float)tries)*100 + "% solved with Random box choice");
Console.WriteLine(((float)numTimesSolvedWithCircle/(float)tries)*100 + "% solved with Circle box choice");
