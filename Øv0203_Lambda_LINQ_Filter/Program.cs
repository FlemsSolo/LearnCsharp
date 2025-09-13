List<int> scores = new List<int> { 85, 67, 92, 45, 76, 88, 59 };

// With Lambda
/* var filteredScores = scores
    .Where(score => score >= 70)
    .Select(score => $"{score}: Pass");*/

// Without Lambda
var filteredScores = from score in scores
    where score >= 70
    select $"{score}: Pass";

Console.WriteLine("Filtered and processed scores:");

foreach (var result in filteredScores)
{
    Console.WriteLine(result);
}