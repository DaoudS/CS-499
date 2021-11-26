using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaReWrite {
	class Task {

		public const String Initialize = "";
		public String taskID;
		public String taskName;
		public String description;

		private String _taskID;
		private String _taskName;
		private String _description;

		public Task() {
			this.taskID = Initialize;
			this.taskName = Initialize;
			this.description = Initialize;
		}

		public Task (String taskID) {
			this.description = Initialize;
			this.taskName = Initialize;
			this.taskID = taskID;
		}

		public Task(String taskID, String taskName, String descritpion) {
			this.description = descritpion;
			this.taskName = taskName;
			this.taskID = taskID;
		}

		public String getTaskID() {
			return taskID;
		}

		public String getTaskName() {
			return taskName;
		}

		public String getDescription() {
			return description;
		}

		public void setTaskID(String taskID) {
			_taskID = taskID;
			if (_taskID == null) {
				throw new InvalidOperationException("Task ID cannot be emtpy");
			} else if (_taskID.Length > 10) {
				throw new InvalidOperationException("TaskID cannot be longer than 10 chracters");
			} else {
				this.taskID = _taskID;
			}
		}

		public void setTaskName() {
			_taskName = taskName;
			if (_taskName == null) {
				throw new InvalidOperationException("Task name cannot be empty");
			} else if (_taskName.Length > 20) {
				throw new InvalidOperationException("Task name cannot be longer than 20 characters");
			} else {
				this.taskName = _taskName;
			}
		}

		public void setDescription() {
			_description = description;
			if (_description == null) {
				throw new InvalidOperationException("Description cannot be empty");
			} else if (_taskName.Length > 50) {
				throw new InvalidOperationException("Description cannot be longer than 50 characters");
			} else {
				this.description = _description;
			}
		}
	}
}
