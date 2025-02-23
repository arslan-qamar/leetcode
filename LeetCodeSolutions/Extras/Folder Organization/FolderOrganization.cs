namespace Extras.Problem_2
{
    public class FolderOrganization
    {
        public static int minFolders(int cssFiles, int jsFiles, int readMeFiles, int capacity)
        {
            if (capacity == 1 && readMeFiles > 0)
            {
                throw new ArgumentException("Invalid capacity with readMeFiles");
            }

            int folders = 0;

            int currentCssFile = cssFiles;
            int currentJsFile = jsFiles;
            int currentReadMeFiles = readMeFiles;

            while (currentCssFile > 0 || currentJsFile > 0 || currentReadMeFiles > 0)
            {
                int takeFiles = capacity;

                if (currentReadMeFiles > 0)
                {
                    takeFiles = capacity - 1;
                }

                currentReadMeFiles = Math.Max(0, --currentReadMeFiles);


                while (takeFiles > 0)
                {
                    bool jsTaken = false;
                    bool cssTaken = false;
                    if (currentCssFile > currentJsFile)
                    {
                        if (currentCssFile > 0 && takeFiles > 0)
                        {
                            currentCssFile = Math.Max(0, --currentCssFile);
                            --takeFiles;
                            cssTaken = true;
                        }

                        if (currentJsFile > 0 && takeFiles > 0)
                        {
                            currentJsFile = Math.Max(0, --currentJsFile);
                            --takeFiles;
                            jsTaken = true;
                        }
                    }
                    else
                    {
                        if (currentJsFile > 0 && takeFiles > 0)
                        {
                            currentJsFile = Math.Max(0, --currentJsFile);
                            --takeFiles;
                            jsTaken = true;
                        }

                        if (currentCssFile > 0 && takeFiles > 0)
                        {
                            currentCssFile = Math.Max(0, --currentCssFile);
                            --takeFiles;
                            cssTaken = true;
                        }
                    }

                    if (jsTaken != cssTaken || (jsTaken == false && cssTaken == false))
                    {
                        break;
                    }
                }

                folders++;
            }

            return folders;
        }
    }

}