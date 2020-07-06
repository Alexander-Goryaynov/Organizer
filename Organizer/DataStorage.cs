using Organizer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Task = Organizer.Models.Task;

namespace Organizer
{
    public class DataStorage
    {
        private static DataStorage instance;
        private const string notesFileName = "Notes.xml";
        private const string tasksFileName = "Tasks.xml";
        private const string categoriesFileName = "Categories.xml";
        public List<Note> Notes { get; set; }
        public List<Task> Tasks { get; set; }
        public List<string> Categories { get; set; }
        private DataStorage()
        {
            Notes = LoadNotes();
            Tasks = LoadTasks();
            Categories = LoadCategories();
        }
        public static DataStorage GetInstance()
        {
            if (instance == null)
            {
                instance = new DataStorage();
            }
            return instance;
        }
        ~DataStorage()
        {
            SaveCategories();
            SaveNotes();
            SaveTasks();
        }
        private List<Note> LoadNotes()
        {
            var list = new List<Note>();
            if (File.Exists(notesFileName))
            {
                XDocument doc = XDocument.Load(notesFileName);
                var elements = doc.Root.Elements("note").ToList();
                foreach(var el in elements)
                {
                    list.Add(new Note
                    {
                        Tags = el.Attribute("tags").Value,
                        Text = el.Attribute("text").Value,
                        CategoryName = el.Attribute("categoryName").Value
                    });
                }
            }
            return list;
        }
        private List<Task> LoadTasks()
        {
            var list = new List<Task>();
            if (File.Exists(tasksFileName))
            {
                XDocument doc = XDocument.Load(tasksFileName);
                var elements = doc.Root.Elements("task").ToList();
                foreach (var el in elements)
                {
                    list.Add(new Task
                    {
                        Text = el.Attribute("text").Value,
                        Deadline = Convert.ToDateTime(el.Attribute("deadline").Value)
                    });
                }
            }
            return list;
        }
        private List<string> LoadCategories()
        {
            var list = new List<string>();
            if (File.Exists(categoriesFileName))
            {
                XDocument doc = XDocument.Load(categoriesFileName);
                var elements = doc.Root.Elements("category").ToList();
                foreach(var el in elements)
                {
                    list.Add(el.Attribute("name").Value);
                }
            }
            return list;
        }
        private void SaveNotes()
        {
            if (Notes != null)
            {
                var xElement = new XElement("notes");
                foreach (var note in Notes)
                {
                    xElement.Add(new XElement("note", new XAttribute("tags", note.Tags),
                        new XAttribute("text", note.Text), new XAttribute("categoryName",
                        note.CategoryName)));
                }
                XDocument doc = new XDocument(xElement);
                doc.Save(notesFileName);
            }
        }
        private void SaveTasks()
        {
            if (Tasks != null)
            {
                var xElement = new XElement("tasks");
                foreach (var task in Tasks)
                {
                    xElement.Add(new XElement("task", new XAttribute("deadline",
                        task.Deadline.ToString()), new XAttribute("text", task.Text)));
                }
                XDocument doc = new XDocument(xElement);
                doc.Save(tasksFileName);
            }
        }
        private void SaveCategories()
        {
            if (Categories != null)
            {
                var xElement = new XElement("categories");
                foreach(var category in Categories)
                {
                    xElement.Add(new XElement("category", new XAttribute("name", category)));
                }
                XDocument doc = new XDocument(xElement);
                doc.Save(categoriesFileName);
            }
        }
    }
}
