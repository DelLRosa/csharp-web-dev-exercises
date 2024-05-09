//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:
static int sumNum(List<int> arr){
    int sum = 0;
    foreach(int num in arr){
        if(num%2==0){
            sum+=num;
        }
    }
    return sum;
}

static void printer(List<string> list){
    System.Console.WriteLine("how many letters are we looking for? ");
    int numLet=Convert.ToInt32(Console.ReadLine());
    foreach(string word in list){
        if (word.Length==numLet){
            System.Console.WriteLine($"The word {word} has {numLet} letters");
        }
    }
}

List<string> wordList = new List<string>{"butt","woo","qw","Hello"};

// List<int> numList = new List<int>{1,2,3,4,5,6,7,8,9,10};
// Console.WriteLine("Hello, Lists!");
// System.Console.WriteLine(sumNum(numList));
printer(wordList);
