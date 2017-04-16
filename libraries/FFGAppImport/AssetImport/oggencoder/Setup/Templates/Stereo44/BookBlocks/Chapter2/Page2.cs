﻿namespace OggVorbisEncoder.Setup.Templates.Stereo44.BookBlocks.Chapter2
{
    public class Page2 : IStaticCodeBook
    {
        public int Dimensions = 4;

        public byte[] LengthList = {
            1, 4, 4, 0, 0, 0, 7, 7, 0, 0, 0, 7, 7, 0, 0, 0,
            8, 8, 0, 0, 0, 0, 0, 0, 0, 4, 6, 6, 0, 0, 0, 8,
            8, 0, 0, 0, 8, 8, 0, 0, 0, 9, 9, 0, 0, 0, 0, 0,
            0, 0, 4, 6, 6, 0, 0, 0, 8, 8, 0, 0, 0, 8, 8, 0,
            0, 0, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 7, 8, 8, 0, 0, 0, 11, 11, 0, 0,
            0, 11, 11, 0, 0, 0, 12, 11, 0, 0, 0, 0, 0, 0, 0, 7,
            8, 8, 0, 0, 0, 10, 11, 0, 0, 0, 11, 11, 0, 0, 0, 11,
            12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 6, 8, 8, 0, 0, 0, 11, 11, 0, 0, 0, 11, 11,
            0, 0, 0, 12, 12, 0, 0, 0, 0, 0, 0, 0, 6, 8, 8, 0,
            0, 0, 10, 11, 0, 0, 0, 10, 11, 0, 0, 0, 11, 11, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            8, 9, 9, 0, 0, 0, 11, 12, 0, 0, 0, 11, 12, 0, 0, 0,
            12, 11, 0, 0, 0, 0, 0, 0, 0, 8, 10, 9, 0, 0, 0, 12,
            11, 0, 0, 0, 12, 11, 0, 0, 0, 11, 12, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0
        };

        public CodeBookMapType MapType = CodeBookMapType.Implicit;
        public int QuantMin = -533725184;
        public int QuantDelta = 1611661312;
        public int Quant = 3;
        public int QuantSequenceP = 0;

        public int[] QuantList = {
            2,
            1,
            3,
            0,
            4
        };
    }
}