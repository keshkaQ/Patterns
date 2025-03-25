//var projectFileDirectory = new ProjectFileDirectory();
//var projectServer = new ProjectServer();

//var context = new Context(projectFileDirectory);
//context.Execute("");
//context.ChangeProject(projectServer);
//context.Execute("");

//Console.ReadLine();


//public abstract class ProjectFile
//{
//    public abstract void Save(string project);
//}

//public class ProjectFileDirectory : ProjectFile
//{
//    public override void Save(string project)
//    {
//        Console.WriteLine("Save on Disk");
//    }
//}

//public class ProjectServer : ProjectFile
//{
//    public override void Save(string project)
//    {
//        Console.WriteLine("Save on Server");
//    }
//}

//public class Context
//{
//    private ProjectFile _projectFile;
//    public Context(ProjectFile projectFile)
//    {
//        _projectFile = new ProjectFileDirectory();
//    }

//    public void Execute(string project)
//    {
//        _projectFile.Save(project);
//    }

//    public void ChangeProject(ProjectFile projectFile)
//    {
//        _projectFile = projectFile;
//    }

//}