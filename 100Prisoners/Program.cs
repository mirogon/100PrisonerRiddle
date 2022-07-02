using _100Prisoners;

const int NUM_BOXES = 100;
if(NUM_BOXES%2 != 0) {
    Console.WriteLine("NUMBER OF BOXES HAS TO BE DIVISIBLE BY 2");
    Environment.Exit(-1);
}

Boxes boxes = new Boxes(NUM_BOXES);

Prisoner[] prisoners = new Prisoner[NUM_BOXES];
for(int i = 0; i < prisoners.Length; ++i) {
    prisoners[i] = new Prisoner(i+1);
}

bool RandomSearch(Prisoner p, Box[] boxes) {
    bool foundBox = false;
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
            foundBox = true;
        }
    }
    return foundBox;
}

bool CircleSearch(Prisoner p, Box[] boxes) {
    int boxToSearch = p.PrisonerNumber;

    for(int i = 0; i < NUM_BOXES/2; ++i) {
        //Search right box
        Box? b = null;
        for(int j = 0; j < boxes.Length; ++j) {
            if (boxes[j].OutsideNumber == boxToSearch) {
                b = boxes[j];
            }
        }

        if(b.InsideNumber == p.PrisonerNumber) {
            return true;
        }

        boxToSearch = b.InsideNumber;
    }

    return false;
}

int numPrisonersFoundTheirNumber = 0;
for(int i = 0; i < prisoners.Length; ++i) {
    if (CircleSearch(prisoners[i], boxes.BoxList)) {
        ++numPrisonersFoundTheirNumber;
    }
}

Console.WriteLine("Number of Prisoners: " + prisoners.Length);
Console.WriteLine(numPrisonersFoundTheirNumber + " Found their number");

