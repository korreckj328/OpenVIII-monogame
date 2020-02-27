﻿using System.IO;

namespace OpenVIII
{
    public sealed partial class ArchiveZzz
    {
        #region Classes

        private static class Header
        {
            #region Methods

            /// <summary>
            /// Convert ZZZ header to an Archive Map.
            /// </summary>
            /// <param name="br">Binary Reader containing raw data</param>
            /// <returns>ArchiveMap</returns>
            public static ArchiveMap Load(BinaryReader br)
            {
                int capacity = br.ReadInt32();
                ArchiveMap r = new ArchiveMap(capacity);
                for (int i = 0; i < capacity; i++)
                    r.Add(FileData.Load(br));
                return r;
            }

            #endregion Methods
        }

        #endregion Classes
    }
}