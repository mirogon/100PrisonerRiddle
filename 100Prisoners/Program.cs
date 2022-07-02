using _100Prisoners;

const int NUM_BOXES = 1000;
if(NUM_BOXES%2 != 0) {
    Console.WriteLine("NUMBER OF BOXES HAS TO BE DIVISIBLE BY 2");
    Environment.Exit(-1);
}

Boxes boxes = new Boxes(NUM_BOXES);

Prisoner[] prisoners = new Prisoner[NUM_BOXES];
for(int i = 0; i < prisoners.Length; ++i) {
    prisoners[i] = new Prisoner(i+1);
}

bool PrisonerFindsHisBox(Prisoner p, Box[] boxes) {
    bool prisonerFoundHisBox = false;
    List<int> availableBoxes = new List<int>();
    for(int i = 0; i < boxes.Length; ++i) {
        availableBoxes.Add(i);
    }

    for(int i = 0; i < NUM_BOXES/2; ++i) {
        Random r = new Random();
        int availableBoxesIndex = r.Next(availableBoxes.Count);
        int boxIndex = availableBoxes[availableBoxesIndex];
        availableBoxes.RemoveAt(availableBoxesIndex);

        if (boxes[boxIndex].InsideNumber == p.PrisonerNumber) {
            prisonerFoundHisBox = true;
        }
    }
    return prisonerFoundHisBox;
}

int numPrisonersFoundTheirNumber = 0;
for(int i = 0; i < prisoners.Length; ++i) {
    if (PrisonerFindsHisBox(prisoners[i], boxes.BoxList)) {
        ++numPrisonersFoundTheirNumber;
    }
}

Console.WriteLine("Number of Prisoners: " + prisoners.Length);
Console.WriteLine(numPrisonersFoundTheirNumber + " Found their number");

