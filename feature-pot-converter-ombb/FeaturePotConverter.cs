using System;

namespace feature_pot_converter_ombb
{
    public static class FeaturePotConverter
    {
        private static string ConvertToBinary(int value)
        {
            return Convert.ToString(value, 2);
        }

        private static string MatchBinaryLength(string binary, int length)
        {
            while (binary.Length < length)
            {
                binary = "0" + binary;
            }
            return binary;
        }

        private static string ConvertReelsToBinary(int reel1, int reel2, int reel3, int reel4, int reel5, int reel6, int length)
        {
            return MatchBinaryLength(ConvertToBinary(reel1), length) +
                MatchBinaryLength(ConvertToBinary(reel2), length) +
                MatchBinaryLength(ConvertToBinary(reel3), length) +
                MatchBinaryLength(ConvertToBinary(reel4), length) +
                MatchBinaryLength(ConvertToBinary(reel5), length) +
                MatchBinaryLength(ConvertToBinary(reel6), length);
        }

        private static int ConvertBinaryStringToInt(string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        public static int ConvertFeaturePots(string reel1, string reel2, string reel3, string reel4, string reel5, string reel6, int length)
        {
            return ConvertBinaryStringToInt(ConvertReelsToBinary(int.Parse(reel1), int.Parse(reel2), int.Parse(reel3), int.Parse(reel4), int.Parse(reel5), int.Parse(reel6), length));
        }
    }
}
