public class WritingAssigment : Assigment{
    private string _title;
    
    public WritingAssigment(string studentName, string title, string topic) : base(studentName, title){
        _topic = topic;
    }

    public string GetWritingInfo(){
        return $"\n{_title} \n{_studentName} - {_topic} ";

    }


}