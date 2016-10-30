using System;


namespace HW9_FileHandle
{
    
        public struct FileHandle
        {
            public long FileSize { get; set; }
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public FileAccessEnum FileAccessEnum { get; set; }



            public FileHandle(long fileSize, string fileName, string filePath, FileAccessEnum fileAccessEnum) 
            {

                FileSize = fileSize;
                FileName = fileName;
                FilePath = filePath;
                FileAccessEnum = fileAccessEnum;
            }



            public override string ToString()
            {
                return String.Format("{0} {1} {2}", FileName, FileSize, FilePath);
            }
       
    }
}
