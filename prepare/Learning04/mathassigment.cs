public class MathAssigment : Assigment{
    private string _textbookSection;
    private string _problems;
    public MathAssigment(string textbookSection, string problems) : Assigment(string studentName, string topic){
        _textbookSection = textbookSection;
        _problems = problems;

    }
    public string GetHomeworkList(){
        return $"Section {_textbookSection} Problems {_problems}";
    }
}