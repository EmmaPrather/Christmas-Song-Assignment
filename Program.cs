using System;
using System.Runtime.CompilerServices;



Console.Title = "The Twelve Days Of Christmas";

string[] days = new string[] { " first ", " second ", " third ", " fourth ", " fith ", " sixth ", " seventh ", " eight ", " ninth ", " tenth ", " eleventh ", " twelfth " };

string[] gifts = new string[] { "a Partridge in a pear tree", "two turtle doves", "three French hens", "four calling birds", "five golden rings", "six geese a laying", "seven swans a swimming", "eight maids a milking", "nine ladies dancing", "Ten lords a leaping", "eleven pipers piping", "twelve drummers drumming" };

Console.Title = "The Twelve Days Of Christmas...";
Console.WindowHeight = Console.LargestWindowHeight - 20;
Header();


for (int j = 0; j < 12; j++)
{

    Console.WriteLine("On the" + days[j] + "day of christmas my true love gave to me " + gifts[j] + ",");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Prev(j - 1, gifts, days);
    Console.ResetColor();
}

void Prev(int prevgifts, string[] gifts, string[] days)
{

    for (int i = prevgifts; i >= 0; i--)
    {
        if (i == 0)
        {
            Console.WriteLine("and " + gifts[i] + "." + "\n");

        }
        else
        {
            Console.WriteLine(gifts[i] + ",");
        }





    }



}



void Header()
{
    string header = @"
The Twelve                                 
       Days Of                 
           Christmas   


                                                _...._
                       \  _  /                .::o:::::.
                        (\o/)                .:::'''':o:.
                    ---  / \  ---            :o:_    _:::
                         >*<                 `:}_>()<_{:'
                        >0<@><             @    `'//\\'`    @
                       >>>@<<*          @ #     //  \\     # @
                      >@>*<0<<<       __#_#____/'____'\____#_#_
                     >*>>@<<<@><<     [_________________________]
                    >@>>0<<<*<<@><     |=_- .-/\ /\ /\ /\--. =_-|
                   >*>>0<<@><<<@><<<    |-_= | \ \\ \\ \\ \ |-_=-|
                  >@>>*<<@><>*<<0<*<   |_=-=| / // // // / |_=-_|
    \*/          >0>>*<<@><>0><<*<@><<  |=_- |`-'`-'`-'`-'  |=_=-|
___\\U//___     >*>>@><0<<*>>@><*<0<< | =_-| o          o |_==_|
|\\ | | \\|    >@>>0<*<<0>>@<<0<<<*<@><|=_- | !     (    ! |=-_=|
| \\| | _(UU)_ >((*))_>0><*<0><@><<<0<*<-,-=| !    ).    ! |-_-=|
|\ \| || / //||.*.*.*.|>>@<<*<<@>><0<<<((=_| ! __(:')__ ! |=_==|
|\\_|_|&&_// ||*.*.*.*|_\\db//__     (\_/)-|/^\=^=^^=^=/^\| _=_|
""""|'.'.'.|~~|.*.*.*|     ____|_   =('Y')=//,------------.
    |'.'.'.|   ^^^^^^|____|>>>>>>|  ( ~~~ )/(((((((())))))))
    ~~~~~~~~         '""""`------'  `w---w`  `------------'




";
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(header);
    Console.ResetColor();

}
