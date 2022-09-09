





string GetUserInput() {
    string answer = Console.ReadLine();
    if (answer == null)
    {
        Console.WriteLine("Please enter a valid city name");
    }
    return answer;
}