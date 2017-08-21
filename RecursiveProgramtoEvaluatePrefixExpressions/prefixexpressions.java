import static java.lang.System.out;//中文注释
 class prefixexpressions
{
  
   static String str = "* + 7 * * 4 6 + 8  9  5 ";//"* 6 + + 5 * + 2 3 8 30 ";; 
    static char[] a= str.toCharArray();
    static int i; 
    
    static int eval() 
  { int x = 0; 
    while (a[i] == ' ') i++; 
    if (a[i] == '+') 
      { i++; return eval() + eval(); } 
    if (a[i] == '*') 
      { i++; return eval() * eval(); } 
    while ((a[i] >= '0') && (a[i] <= '9')) 
      x = 10*x + (a[i++]-'0'); 
    return x; 
  } 

   public static void main(String[] args)
   {
      System.out.println("We will not use 'Hello, World!'");
      byte b = (byte)129;//这种类型转换和byte(129)不同,后者从语法上是运行时调用构造,而前者是告知编译器?
      System.out.println(b);
      short c = 129;
      System.out.println(c);   
      
      out.println(eval());
   }
   
   }




