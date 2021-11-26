using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JavaReWrite {
	class TaskService {
		private List<Task> tasks = new List<Task>();

		public List<Task> getTaskID() {
			return tasks;
		}

		public String genTaskID() {
			var rand = new Random();
			String taskID = rand.Next(1, 99).ToString();
			Console.WriteLine(taskID);

			return taskID;
		}

		public void addTask() {
			Task task = new Task(genTaskID());
			tasks.Add(task);
		}

		public void addTask(String taskID, String taskName, String description) {
			Task task = new Task(genTaskID(), taskName, description);
			tasks.Add(task);
		}

		public void removeTask(String taskID) {
			try {
				tasks.Remove(findTask(taskID));
			} catch (ArgumentNullException) {
				throw;
			}
		}

		public Task findTask(String taskID) {
			int index = 0;
			while (index < tasks.Count) {
				if (taskID.Equals(tasks[index].taskID)) {
					return tasks[index];
				}
				index++;
			}
			throw new Exception("Task does not exist");
		}

		public void updateDescripton(String taskID, String description) {
			try {
				findTask(taskID).description = description;
			} catch (Exception) {

				throw;
			}
		}

		public void updatetaskName (String taskName, String taskID) {
			try {
				findTask(taskID).taskName = taskName;
			} catch (Exception) {

				throw;
			}
		}
	}
}
