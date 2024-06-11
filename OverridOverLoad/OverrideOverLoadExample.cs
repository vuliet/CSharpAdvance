namespace OverrideOverLoad
{
    class OverrideOverLoadExample
    {
        public virtual string FixKeyWord(string keyword)
        {
            if (string.IsNullOrEmpty(keyword)) return "chuoi bi rong hoac null";
            return string.Format("chuoi sau khi fix: {0} fixed", keyword);
        }

        public static string FixKeyWord(string keyword, bool isFlag)
        {
            if (string.IsNullOrEmpty(keyword) || isFlag == false) return "chuoi bi rong hoac null hoac isFlag = false";
            return string.Format("chuoi sau khi fix: {0} fixed", keyword);
        }
    }
}
