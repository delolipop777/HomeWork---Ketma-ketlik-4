
// 1-vazifa: Katta harf tekshiruvi (Char & Bool)
Console.WriteLine("Iltimos, bitta harf kiriting");
string inputChar = Console.ReadLine();
char ch = inputChar.Length > 0 ? inputChar[0] : '\0';
bool isUpper = ch >= 'A' && ch <= 'Z';
Console.WriteLine(isUpper ? "HA" : "YOʻQ");

// 2-vazifa: Ha/yoʻq javobini berish (Bool)
Console.WriteLine("Dasturlash yoqadimi? (H/Y)");
string answer = Console.ReadLine();
char ansChar = answer.Length > 0 ? answer[0] : '\0';
bool likeProgramming = ansChar == 'H' || ansChar == 'h';
Console.WriteLine(likeProgramming ? "Ajoyib!" : "Afsus!");

// 3-vazifa: Ismdagi birinchi harf (String & Char)
Console.WriteLine("Ismingizni kiriting");
string name = Console.ReadLine();
char firstChar = name.Length > 0 ? name[0] : '\0';
Console.WriteLine(firstChar);
