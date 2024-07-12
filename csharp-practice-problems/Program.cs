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

//Mean and median of the array
MeanAndMedian meanAndMedian = new MeanAndMedian();
Console.WriteLine("----------- Mean and Median of an unsorted array --------------");
meanAndMedian.FindMandM([4,4,4,4]);

//find if the given number is armstrong number or not
ArmstrongNumber asNum = new ArmstrongNumber();
Console.WriteLine("---------- Armstrong Number or Not -------------");
asNum.isArmstrong(120);

//reverse the given number
ReverseNumber reverseNum = new ReverseNumber();
Console.WriteLine("--------- Revesing of a number -----------");
reverseNum.reverse(4372891);
reverseNum.apprach2(12345);

//Remove spaces for the given string
RemoveSpaces remSpace = new RemoveSpaces();
Console.WriteLine("--------- Remove the spaces from the given string ---------");
remSpace.spaceRemove("Have a good day");

//Sum of digits of N is palindrome or not
SumOfDigitsIsPalindrome checkPalindrome = new SumOfDigitsIsPalindrome();
Console.WriteLine("----------- Check if the sum of digits of N is palindrome ---------------");
checkPalindrome.digitSum(5539);

//Print the multiplication table of a number
MultiplicationTable mTable = new MultiplicationTable();
Console.WriteLine("--------- Multiplication Table ----------");
mTable.table(5);

//Revesing vowels in the given string
ReversingVowelsInString reverseStr = new ReversingVowelsInString();
Console.WriteLine("----------- Reversing vowles in the given string --------------");
reverseStr.revStr("Hello World");

//Given the number on one side of the dice and we need to guess the number on the opposite side of given number
DiceProblem dice = new DiceProblem();
Console.WriteLine("---- Guess the number on the opposite face of the dice -----");
dice.guessOppNum(5);

//Remove vowels from the string
RemoveVowelsFromString remVow  = new RemoveVowelsFromString();
Console.WriteLine("----------- Remove the vowels from the given string -------------");
remVow.removeVowels("What is your name ?");

//Count the camel case  characters present in the given string
CountCamelCase cou = new CountCamelCase();
Console.WriteLine("------------- Count of camel case characters present in the given string ----------");
cou.countCamel("GOODDadeEar");

// Find the remainder when num1 is divided by num2
RemainderEvaluation rem = new RemainderEvaluation();
Console.WriteLine("--------- Find the remainder of num1 and num2 ----------");
rem.eval(15,3);

//Convert character list into string
CharListToString chSt = new CharListToString();
Console.WriteLine("----------- Change the char list to string ----------");
chSt.charactToString(['a','b','c','d']);

//Count the number of unique characters
UniqueCharacters uniCh = new UniqueCharacters();
Console.WriteLine("------------- Count of number of unique characters in the given string ----------");
uniCh.uniCharacter("madam");

//Find n-th term of series 1,3,6,10,15,21..........
NthTermOfSeries nthTerm = new NthTermOfSeries();
Console.WriteLine("----------- Find n-th term of series 1,3,6,10,15,21........ -------------");
nthTerm.findN(3);
Console.WriteLine(nthTerm.approach2(4));

//Find the simple intrest
SimpleIntrest si = new SimpleIntrest();
Console.WriteLine("--- FInd the simple Intrest --------");
si.findSI(1, 1, 1);

//Sum of arithmetic series
ArithmeticSeries aseries = new ArithmeticSeries();
Console.WriteLine("------------ Sum of arithmetic series ------------");
aseries.SumOfAS(2.5f, 1.5f, 20);

//Find factorial of a nummber
Factorial factorial = new Factorial();
Console.WriteLine("---------- Factorial of a number --------");
Console.WriteLine(factorial.fact(6));

//Calculate the distance between two points
DistanceBetweenTwoPoints distance = new DistanceBetweenTwoPoints();
Console.WriteLine("------------------ Distance between two points ---------------");
distance.PointDistance(3, 4, 7, 7);

//Sum of geometric series
GeometricSeries geometric = new GeometricSeries();
Console.WriteLine("----------------- Sum of Geometric Series --------------");
geometric.SumOfGS(2, 2, 15);

//Extract all integers from a given string
ExtractIntegersFromString extr = new ExtractIntegersFromString();
Console.WriteLine("--------- Extract all integers from a given string ------------------");
extr.IntegerExtract("1Hello2 &*how are y5ou".ToCharArray());
Console.WriteLine();

//Display Longest Name in the given array of strings
DisplayLongestName dName = new DisplayLongestName();
Console.WriteLine("------------ Display Longest Name in the given array of strings ---------------");
dName.displayLong(["GeeksForGeeks", "FreeCodeCamp", "StackOverFlow", "MyCodeSchool"]);

//Find the volume and surface area of the cuboid
Cuboid cube = new Cuboid();
Console.WriteLine("------------- Volume and Surface area of Cuboid -----------");
cube.volumeAndSurfaceArea(2, 3, 4);

//Floyd Triangle
FloydTriangle floydTri = new FloydTriangle();
Console.WriteLine("-------------- Print Floyd's Tiangle ---------------");
floydTri.FTraingle(5);

//Cube root of a number
CubeRoot cubeRoot = new CubeRoot();
Console.WriteLine("------------- Cube root of a number -----------");
cubeRoot.FindCubeRoot(3);

//Check if two given matrices are identical
int[,] arr1 = new int[4, 4] { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4,4,4,4} };
int[,] arr2 = new int[4, 4] { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };
CheckTwoMatricesIdentical checkIden = new CheckTwoMatricesIdentical();
Console.WriteLine("------------ Check if the given matrices are identical or not ----------------");
checkIden.CheckIdentical(arr1, arr2);

//Compute sums of diagonlas of a square matrix
int res1, res2;
SumOfDiagonals diagSum = new SumOfDiagonals();
Console.WriteLine("----------- Compute sums of diagonals of a square matrix ----------------");
diagSum.diagnolsSum(arr1, out res1, out res2);

//Check if the number is automorphic or not
AutomorphicNumber auto = new AutomorphicNumber();
Console.WriteLine("---------------- Automorphic or Not -----------------");
auto.IsAutomorphic(76);
auto.IsAutomorphic(7);


//Find difference between sums of two diagonals of square matrix
int[,] arr3 = new int[3, 3] { {11,2,4}, {4,5,6 }, {10,8,-12 } };
DifferenceBetweenSumofDiagonals difference = new DifferenceBetweenSumofDiagonals();
Console.WriteLine("-------------- Difference between sums of two diagonals of square matrix ----------------");
Console.WriteLine(difference.getDifference(arr3));

//Find the number of diagonals in n sided convex polygon
DiagonalsInNsidedPolygon diagn = new DiagonalsInNsidedPolygon();
Console.WriteLine("------------------ Number of DIagonals in n sided conves polygon -------------------");
diagn.diagonalCount(4);

//Toeplitz or not
int[,] arr4 = { {6,3,8 }, {4,9,7 }, {1,4,6 } };
ToeplitzOrNot toe = new ToeplitzOrNot();
Console.WriteLine("----------------- Toeplitz or not ---------------------");
Console.WriteLine(toe.IsToeplitz(arr4) ? "Toeplitz Matrix" : "Not Toeplitz Matrix");

//Find maximum occuring character in a string
CountCharacterOccurences charCountOcc  = new CountCharacterOccurences();
Console.WriteLine("---------- Find the maximum occurring character in a string ------------");
charCountOcc.countOccurence("geeksforgeeks");

//Find uncommon characters of the two strings
UncommonCharacters uncommonCharacters = new UncommonCharacters();
Console.WriteLine("-------------- Find uncommon characters of two strings -----------------");
uncommonCharacters.printUncommonChar("characters", "alphabets");

//Remove all consecutive duplicates from the string
RemoveConsecutiveDuplicates remove = new RemoveConsecutiveDuplicates();
Console.WriteLine("-------------------- Remove consecutive duplicates -----------------------");
remove.remConDupl("geeks for test");

//Replace 0's with 5
ReplaceDigit repDigit = new ReplaceDigit();
Console.WriteLine("--------------- Replace all 0's with 5 --------------------");
Console.WriteLine(repDigit.replace(1050));

//Find the number occurring odd number of times
OddTimesOccurence odd = new OddTimesOccurence();
Console.WriteLine("------------- Find the number occurring odd number of times -------------------");
odd.oddTimes([5,7,2,7,5,2,5]);

//Find the Earliest Repeating Character
EarliestRepeatingCharacter ear = new EarliestRepeatingCharacter();
Console.WriteLine("----------------- Find the earliest repeating character ----------------");
ear.getEarliest("getup eat");

//Program to check if a given year is leap year
LeapYear lp = new LeapYear();
Console.WriteLine("------------------------ Program to check if a given year is leap year ----------------------");
lp.IsLeap(2023);

//Solid and hollow patterns
SolidAndHollowSquare sh = new SolidAndHollowSquare();
Console.WriteLine("-------------- Solid and Hollow Patterns ---------------------");
sh.sAndh(4);

//Print Right triangle star pattern
RightTriangle rt = new RightTriangle();
Console.WriteLine("--------- Print Right Triangle start pattern -------------------");
rt.printRightTriangle(5);

//Find a pair with maximum product in array of integers
MaximumProduct mp = new MaximumProduct();
Console.WriteLine("--------------- Pair of maximum product in array of integers ------------------------");
mp.FindMax([1,4,3,6,7,0]);

static int val(ref int b)
{
    b = 10;
    return 9;
}
