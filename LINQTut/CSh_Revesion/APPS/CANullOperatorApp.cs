

namespace CSh_Revesion.APPS;

internal class CANullOperatorApp
{
    #region Null Operators
    /*
     * Null Operators :
     * 1: Null-Coalescing Operator (??)
     *      It says >> “If the operand to the le is non-null, give it to me;
                        otherwise, give me another value.”
     * 2: Null-coalescing assignment operator (??=)  (introduced in C# 8)
     *      It says >>  “If the operand to the le is null,
                          assign the right operand to the left operand.”
     * 3: Null-conditional operator (?.)
     *      It says >>  “if the operand on the left is null,the expression evaluates to null 
                            instead of throwing a NullReferenceException.”
     * */
    #endregion
    public static void Run(string[] args)
    {
        string? s1 = null;

        string? s2 = s1 ?? "nothing";

        string? s3 = s1?.ToUpper();

        s1 ??= "Hello,World!";
    }
}
