// single inheritance
//multiple inheritance is possible through interface
class CSStudent : Student , IGradeable //IGradeable is interface and  it is multiple inheritance
{
    public CSStudent(string name , byte rn , string pTitle): base(name,rn)//base class is used to call parent class constructor
    {
        ProjectTitle = pTitle;
    }
    public string ProjectTitle { get; set; }
    public string InternWork { get; set; }

    public double GetGrade()=> 3.6;
}