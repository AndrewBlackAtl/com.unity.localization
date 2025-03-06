namespace UnityEngine.Localization.Tables
{
    public class KeyHashIDGenerator : IKeyGenerator
    {
        public long GetNextKey(string key) => key.GetHashCode();
    }
}