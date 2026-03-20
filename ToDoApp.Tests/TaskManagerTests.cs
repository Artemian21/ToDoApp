using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Tests
{
    internal class TaskManagerTests
    {
        [Test]
        public void AddTask_ShouldIncreaseCount()
        {
            // Arrange
            var manager = new TaskManager();

            // Act
            manager.AddTask("Test");

            // Assert
            Assert.That(manager.GetTasksCount(), Is.EqualTo(1));
        }

        [Test]
        public void MarkAsDone_ShouldSetTaskDone()
        {
            // Arrange
            var manager = new TaskManager();
            manager.AddTask("Test");

            // Act
            manager.MarkAsDone(0);

            // Assert
            Assert.That(manager.GetAllTasks()[0].IsDone, Is.True);
        }
    }
}
