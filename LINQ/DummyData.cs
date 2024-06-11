using System.Collections.Generic;

public class DummyData
{
    public static List<Student> ListStudent() => new List<Student>
    {
        new Student
        {
            StudentID = 1,
            StudentName = "VKCT",
            Age = 24
        },
        new Student
        {
            StudentID = 2,
            StudentName = "ABC",
            Age = 23
        },
        new Student
        {
            StudentID = 3,
            StudentName = "ThaoLEU",
            Age = 23
        }
    };

    public static List<Character> ListCharacter() => new List<Character>
    {
        new Character
        {
            CharacterID = 4,
            CharacterName = "VKCT",
            CharacterAge = 25,
            ListJob = new List<Job>()
            {
                new Job()
                {
                    JobID = 1,
                    JobName = "Race Car",
                    IsActive = true
                },
                new Job()
                {
                    JobID = 2,
                    JobName = "FootBall Player",
                    IsActive = true
                },
                new Job()
                {
                    JobID = 3,
                    JobName = "Singer"
                },
            }
        },
        new Character
        {
            CharacterID = 5,
            CharacterName = "ABCD",
            CharacterAge = 24,
            ListJob = new List<Job>()
            {
                new Job()
                {
                    JobID = 4,
                    JobName = "Doctor"
                },
                new Job()
                {
                    JobID = 5,
                    JobName = "Teacher"
                },
                new Job()
                {
                    JobID = 6,
                    JobName = ""
                },
            }
        },
        new Character
        {
            CharacterID = 6,
            CharacterName = "ThaoLEUNgu",
            CharacterAge = 23,
            ListJob = new List<Job>()
            {
                new Job()
                {
                    JobID = 7,
                    JobName = ""
                },
                new Job()
                {
                    JobID = 8,
                    JobName = ""
                },
                new Job()
                {
                    JobID = 9,
                    JobName = ""
                },
            }
        }
    };

    public class Job
    {
        public int JobID { get; set; }
        public string JobName { get; set; }
        public bool IsActive { get; set; }
    }
}

