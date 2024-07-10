using csharp_practice_problems.Problems;

// Reversing a string
ReverseAString reverseAString = new ReverseAString();
Console.WriteLine("--------- Reverse a string ----------------");
Console.WriteLine(reverseAString.StringReverse("Hello World"));

//Palindrome or not
Palindrome palindrome = new Palindrome();
Console.WriteLine("------------- Palindrome -------------");
Console.WriteLine(palindrome.PalindromeOrNot("madam"));
Console.WriteLine(palindrome.PalindromeOrNot("Honey"));

//Revese the words in a string
ReverseOrderOfWords reverseOrderOfWords = new ReverseOrderOfWords();
Console.WriteLine("----------- Reversing words in string --------------");
reverseOrderOfWords.reverseWords("Hello World");

//Reverse each word in a string
ReverseEachWord reverseEachWord = new ReverseEachWord();
Console.WriteLine("-------------- Reversing each word in a string --------------------");
reverseEachWord.WordReverse("Hello World");

//Count the occurence of the letter in string
CharacterOccurence characterOccurence = new CharacterOccurence();
Console.WriteLine("-------------- Count the occurence of each character --------------------");
characterOccurence.CountOccurrence("Hello World");

//Remove duplicate characters
RemoveDuplicates removeDuplicates = new RemoveDuplicates();
Console.WriteLine("-------------- Remove duplicate characters --------------------");
removeDuplicates.remDuplicates("csharpcorner");

//all possible substrings of the string
PossibleSubstrings possibleSubstrings = new PossibleSubstrings();
Console.WriteLine("--------------- Possible substrings of a string -----------------");
possibleSubstrings.PosSubString("abcd");

//Left circular rotation
LeftCircularRotation leftCircularRotation = new LeftCircularRotation();
Console.WriteLine("------------- Left circular rotation on array ----------------");
leftCircularRotation.LeftCircle([5, 1, 2, 3, 4]);
Console.WriteLine();

//right circular rotation
RightCircularRotation rightCircularRotation = new RightCircularRotation();
Console.WriteLine("-------------- Right circular rotation on arrar ---------------");
rightCircularRotation.RightCircle([1, 2, 3, 4, 5]);

//prime or not
PrimeNumber primeNumber = new PrimeNumber();
Console.WriteLine("----------- Prime number or not --------------------");
Console.WriteLine(primeNumber.CheckPrime(181));

//Sum of digits of a positive integer
SumOfDigits sumOfDigits = new SumOfDigits();
Console.WriteLine("---------------- Sum of digits of a positive integer -----------------");
sumOfDigits.DigitsSum(51);

//Second Largest integer in an array
SecondLargetInteger secondLargetInteger = new SecondLargetInteger();
Console.WriteLine("------------- Second Largest Integer ---------------");
secondLargetInteger.secondLargest([5, 1, 2, 3, 4]);


//Third Biggest integer in an array
ThirdLargestInteger thirdLargestInteger = new ThirdLargestInteger();
Console.WriteLine("-------------- Third Largest Integer --------------------");
thirdLargestInteger.thirdLargest([98, 95, 86, 45, 32, 61]);

//Two Dimensional Array to One Dimensional Array
TwoDtoOneD twoo = new TwoDtoOneD();
Console.WriteLine("------------- 2D to 1D array -----------------");
int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
twoo.convertTwoDtoOneD(arr);

//Two Dimentional Array to One Dimentional Array
OneDtoTwoD oneDtoTwoD = new OneDtoTwoD();
Console.WriteLine("----------- 1D to 2D Array ------------");
int[] array = { 1, 2, 3, 4, 5, 6 };
oneDtoTwoD.convertOneD(array, 2, 3);

//Angle between hour and minutes hand
AngleBetweenHandM angleBetweenHandM = new AngleBetweenHandM();
Console.WriteLine("------------------- Angle betwen hour and minute hands in a clock -------------------");
angleBetweenHandM.findAngle(1, 50);

//Add even numbers in the array of numbers
AddEvensInArray addEvensInArray = new AddEvensInArray();
Console.WriteLine("------------------------ Sum of even numbers in the given arra of numbers -----------------------");
addEvensInArray.evenSum([23, 2, 3, 32, 66, 6]);


int a = 5;

Console.WriteLine(a);
int result = val(ref a);

Console.WriteLine(a);

AddEvensInArray addEvensInArray1 = new AddEvensInArray();
AddEvensInArray addEvensInArray2 = addEvensInArray1;

Console.WriteLine(addEvensInArray1.GetHashCode());
Console.WriteLine(addEvensInArray2.GetHashCode());

// Sum of sum-series of N Natural numbers
SumOfSumSeries sumSeries = new SumOfSumSeries();
Console.WriteLine("------------- Sum of sum-series of N natural numbers ------------------");
sumSeries.SumSumSeries(6);
sumSeries.approach2(6);

//check if the number is binary or not
NumberBinaryOrNot numberBinaryOrNot = new NumberBinaryOrNot();
Console.WriteLine("------------- Check if a number is binary or not ------------------");
numberBinaryOrNot.CheckBinary(1234);

CheckNumberEvenOrOdd checkNumberEvenOrOdd = new CheckNumberEvenOrOdd();
Console.WriteLine("------------ Check number is even  or odd -----------------");
checkNumberEvenOrOdd.EvenOdd(25);

//string res = (26 % 2) == 0 ? "Even" : "Odd";
Console.WriteLine("----- Check number is even or odd using ternary operator ------");
Console.WriteLine((26 % 2) == 0 ? "Even" : "Odd");

//swapping two numbers
SwappingTwoNumbers sw = new SwappingTwoNumbers();
Console.WriteLine("------------ Swapping two numbers --------------");
sw.swapping(50, 200);

//Sum of all elements of a matrix
SumOfAllMatrixElements sum = new SumOfAllMatrixElements();
Console.WriteLine("-------------- Sum of all elements of the matrix -------------");
int[,] input = new int[3, 4] { { 4, 5, 3, 2 }, { 9, 5, 6, 2 }, { 1, 5, 3, 5 } };
sum.MatrixSum(input);

//Vowel or not
CharacterVowelorNot charCheck = new CharacterVowelorNot();
Console.WriteLine("----------- Character is Vowel or Not -------------");
charCheck.IsVowel('O');

//Largest number among three numbers
LargestNumberAmongThree largestNumberAmongThree = new LargestNumberAmongThree();
Console.WriteLine("------------ Find Largest number among three numbers ------------");
largestNumberAmongThree.largestNum(8, 10, 50);

//Change the lower case string to the upper case string
LowerCaseToUpperCase lowerCaseToUpperCase = new LowerCaseToUpperCase();
Console.WriteLine("-------------- Lowercase to Uppercase String -------------");
lowerCaseToUpperCase.lowerToUpper("GeeksForGeeks");

//Multiply all the elements in the given array
MultiplyElementsOfArray multiplyElementsOfArray = new MultiplyElementsOfArray();
Console.WriteLine("--------------- Product os array elements ------------");
multiplyElementsOfArray.elementsProduct([1, 3, 5, 7, 9]);

//Find the even indexers sum and odd indexers sum of the given array
EvenSumOddSum evenSumOddSum = new EvenSumOddSum();
Console.WriteLine("---------- Sum of even indexer values and sum of odd indexer values of an array ------------");
evenSumOddSum.sumEvenSumOdd([1, 2, 3, 4, 5, 6]);

//print all the stars in the diamond pattern
DiamondPattern diamondPattern = new DiamondPattern();
Console.WriteLine("------- Printing Diamond Pattern -------------");
diamondPattern.pattern(5);
   
//print the stars in the half diamond shape
HalfDiamond halfDiamond = new HalfDiamond();
Console.WriteLine("------------ Half Diamond Pattern ------------------");
halfDiamond.halfDiamondPattern(5);

//print the alternate elemnets of the given array
AlternateElementsofArray Alternate = new AlternateElementsofArray();
Console.WriteLine("---------- Printing alternate elements of given array -----------");
Alternate.alternate([1, 2, 3, 4, 5]);
Console.WriteLine();

//Count the number of digits present in th given number
CountOfDigitsInNumber countOfDigitsInNumber = new CountOfDigitsInNumber();
Console.WriteLine("--------- Count of the number of digits present in the given number ----------------");
countOfDigitsInNumber.digitCount(112345);

//Check whether the given array is palindrome or not
ArrayPalindrome arrayPal = new ArrayPalindrome();
Console.WriteLine("------------ Array Palindrome or not ------------");
arrayPal.IsArrayPalindrome([3, 6, 0, 2, 3]);

MeanAndMedian meanAndMedian = new MeanAndMedian();
Console.WriteLine("----------- Mean and Median of an unsorted array --------------");
meanAndMedian.FindMandM([4,4,4,4]);

ArmstrongNumber asNum = new ArmstrongNumber();
Console.WriteLine("---------- Armstrong Number or Not -------------");
asNum.isArmstrong(120);

static int val(ref int b)
{
    b = 10;
    return 9;
}
