using System;


namespace HW9_FileHandle
{
   
        [Flags]
        public enum FileAccessEnum
        {
            Read = 0x1,
            Write = 0x2,
            ReadWrite = Read | Write
        }
    
}
