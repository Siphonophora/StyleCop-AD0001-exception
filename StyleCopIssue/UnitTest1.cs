namespace StyleCopIssue
{
    public class Tests
    {
        /// <summary>
        /// Style cop exception doesn't happen if this is remmoved.
        /// </summary>
        public void foo()
        { }

        public record GetDataCase(string caseName, Action<string> dataBuilder)
        {
            public override string ToString() => caseName;
        }
    }
}
