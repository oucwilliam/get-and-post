using System.Text.RegularExpressions;

/// <summary>
/// RegularExpression 的摘要说明
/// </summary>
public class RegularExpression
{
    public RegularExpression()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public Regex number = new Regex("[0-9]");
    public Regex Uppercharacter = new Regex("[A-Z]");
    public Regex noUppercharacter = new Regex("[^A-Z]");
    public Regex Lowercharacter = new Regex("[a-z]");
    public Regex others = new Regex("[^0-9a-zA-Z]");
    public Regex Chinese_character = new Regex("[\u4E00-\u9FA5]");//匹配汉字
    public Regex other = new Regex("[^/s0-9a-zA-Z\u4E00-\u9FA5]|[^,，。.!！@#$%&*_+-=''`~]");
    public Regex nobookname = new Regex("[^a-zA-Z\u4E00-\u9FA5]");
    public Regex space = new Regex("/s");
    public Regex nonumber = new Regex("[^0-9]");
    public Regex Content = new Regex("[<]");
}