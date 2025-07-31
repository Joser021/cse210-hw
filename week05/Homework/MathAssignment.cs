class MathAssignment : Assignment
{
    private string _textBook;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBook, string problems) : base(studentName, topic)
    {
        _textBook = textBook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBook} Problems {_problems}";
    }
}