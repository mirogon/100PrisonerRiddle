using _100Prisoners;

const int numPrisoners = 100;
const int tries = 1000;

int numTimesSolvedWithRandom = 0;
int numTimesSolvedWithCircle = 0;

//Trying to solve the riddle [tries] times with [numPrisoners] prisoners
for(int i = 0; i < tries; ++i) {

    //Create a Prisoner Riddle with 100 Prisoners/Boxes
    RiddleSolver solver = new RiddleSolver(numPrisoners);

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
