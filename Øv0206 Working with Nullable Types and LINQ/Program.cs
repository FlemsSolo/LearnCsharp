List<int?> examScores = new List<int?> { 85, 90, null, 75, 100, null, 95 };
var validScores = examScores.
    Where(score => score.HasValue).
    Select(score => score.Value);
double averageScore = validScores.Average();

Console.WriteLine($"The average score is: {averageScore}");