namespace Лаба_11
{
    public interface IStorable
    {
        void SaveToFile(string filePath);
        void LoadFromFile(string filePath);
    }

    public static class StringExtensions
    {
        public static string Capitalize(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
            return string.Join(" ", words);
        }
    }

    public class Patient : IStorable
    {
        private int patientId;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string diagnosis;

        public int PatientId { get => patientId; set => patientId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Diagnosis { get => diagnosis; set => diagnosis = value; }

        public Patient() : this(0, "", "", DateTime.Now, "") { }
        public Patient(int patientId) : this(patientId, "", "", DateTime.Now, "") { }
        public Patient(int patientId, string firstName, string lastName, DateTime dateOfBirth, string diagnosis)
        {
            this.patientId = patientId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Diagnosis = diagnosis;
        }

        public void UpdateDiagnosis(string newDiagnosis) => diagnosis = newDiagnosis;

        public int GetAge()
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > DateTime.Today.AddYears(-age)) age--;
            return age;
        }
        public override string ToString()
            => $"{FirstName.Capitalize()} {LastName.Capitalize()}, возраст {GetAge()}, диагноз: {Diagnosis}";
        public void SaveToFile(string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                sw.WriteLine(patientId);
                sw.WriteLine(firstName);
                sw.WriteLine(lastName);
                sw.WriteLine(dateOfBirth.ToString("o"));
                sw.WriteLine(diagnosis);
            }
        }

        public void LoadFromFile(string filePath)
        {
            using (var sr = new StreamReader(filePath))
            {
                patientId = int.Parse(sr.ReadLine());
                firstName = sr.ReadLine();
                lastName = sr.ReadLine();
                dateOfBirth = DateTime.Parse(sr.ReadLine());
                diagnosis = sr.ReadLine();
            }
        }
    }

    public class Doctor : IStorable
    {
        private int doctorId;
        private string firstName;
        private string lastName;
        private string specialization;
        private List<Patient> patients;

        public int DoctorId { get => doctorId; set => doctorId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Specialization { get => specialization; set => specialization = value; }
        public List<Patient> Patients => patients;

        public Doctor() : this(0, "", "", "") { }
        public Doctor(int doctorId) : this(doctorId, "", "", "") { }
        public Doctor(int doctorId, string firstName, string lastName, string specialization)
        {
            this.doctorId = doctorId;
            FirstName = firstName;
            LastName = lastName;
            Specialization = specialization;
            patients = new List<Patient>();
        }

        public void AddPatient(Patient patient) => patients.Add(patient);
        public void AddPatient(int patientId, string firstName, string lastName, DateTime dateOfBirth, string diagnosis)
            => patients.Add(new Patient(patientId, firstName, lastName, dateOfBirth, diagnosis));

        public bool RemovePatient(int patientId)
        {
            var p = FindPatient(patientId);
            if (p != null) return patients.Remove(p);
            return false;
        }

        public Patient FindPatient(int patientId) => patients.Find(p => p.PatientId == patientId);
        public int GetPatientCount() => patients.Count;

        public virtual void ExaminePatient(Patient patient)
        {
            Console.WriteLine($"Врач {FirstName.Capitalize()} {LastName.Capitalize()} осматривает пациента {patient.FirstName.Capitalize()} {patient.LastName.Capitalize()}.");
            Console.WriteLine("Общие рекомендации: соблюдайте режим, питайтесь сбалансированно, больше двигайтесь, не пропускайте плановые осмотры.");
        }

        public override string ToString()
            => $"Врач {FirstName.Capitalize()} {LastName.Capitalize()}, специализация: {Specialization}";

        public void SaveToFile(string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                sw.WriteLine(doctorId);
                sw.WriteLine(firstName);
                sw.WriteLine(lastName);
                sw.WriteLine(specialization);
                sw.WriteLine(patients.Count);
                foreach (var p in patients)
                {
                    sw.WriteLine(p.PatientId);
                    sw.WriteLine(p.FirstName);
                    sw.WriteLine(p.LastName);
                    sw.WriteLine(p.DateOfBirth.ToString("o"));
                    sw.WriteLine(p.Diagnosis);
                }
            }
        }

        public void LoadFromFile(string filePath)
        {
            using (var sr = new StreamReader(filePath))
            {
                doctorId = int.Parse(sr.ReadLine());
                firstName = sr.ReadLine();
                lastName = sr.ReadLine();
                specialization = sr.ReadLine();
                int count = int.Parse(sr.ReadLine());
                patients = new List<Patient>();
                for (int i = 0; i < count; i++)
                {
                    int pid = int.Parse(sr.ReadLine());
                    string fn = sr.ReadLine();
                    string ln = sr.ReadLine();
                    DateTime dob = DateTime.Parse(sr.ReadLine());
                    string diag = sr.ReadLine();
                    patients.Add(new Patient(pid, fn, ln, dob, diag));
                }
            }
        }
    }

    public class Cardiologist : Doctor
    {
        public Cardiologist() : base(0, "", "", "Кардиолог") { }
        public Cardiologist(int doctorId, string firstName, string lastName)
            : base(doctorId, firstName, lastName, "Кардиолог") { }

        public override void ExaminePatient(Patient patient)
        {
            Console.WriteLine($"Кардиолог {FirstName.Capitalize()} {LastName.Capitalize()} осматривает пациента {patient.FirstName.Capitalize()} {patient.LastName.Capitalize()}.");
            Console.WriteLine("Рекомендации: контролируйте артериальное давление, ограничьте соль и жирную пищу, избегайте стресса, делайте ЭКГ раз в год.");
        }
    }

    public class Surgeon : Doctor
    {
        public Surgeon() : base(0, "", "", "Хирург") { }
        public Surgeon(int doctorId, string firstName, string lastName)
            : base(doctorId, firstName, lastName, "Хирург") { }

        public override void ExaminePatient(Patient patient)
        {
            Console.WriteLine($"Хирург {FirstName.Capitalize()} {LastName.Capitalize()} осматривает пациента {patient.FirstName.Capitalize()} {patient.LastName.Capitalize()}.");
            Console.WriteLine("Рекомендации: сдайте общий анализ крови и ЭКГ, не ешьте за 8 часов до операции, сообщите о принимаемых препаратах и аллергиях.");
        }
    }

    public class Therapist : Doctor
    {
        public Therapist() : base(0, "", "", "Терапевт") { }
        public Therapist(int doctorId, string firstName, string lastName)
            : base(doctorId, firstName, lastName, "Терапевт") { }

        public override void ExaminePatient(Patient patient)
        {
            Console.WriteLine($"Терапевт {FirstName.Capitalize()} {LastName.Capitalize()} осматривает пациента {patient.FirstName.Capitalize()} {patient.LastName.Capitalize()}.");
            Console.WriteLine("Рекомендации: пейте больше тёплой жидкости, отдыхайте, при температуре выше 38.5 — жаропонижающее, при ухудшении — повторный приём.");
        }
    }
    public abstract class Department
    {
        private readonly int departmentId;
        private string name;
        private Doctor headOfDepartment;
        private List<Doctor> doctors;
        private bool[] beds;

        public int DepartmentId => departmentId;
        public string Name { get => name; set => name = value; }
        public Doctor HeadOfDepartment { get => headOfDepartment; set => headOfDepartment = value; }
        public List<Doctor> Doctors => doctors;
        public bool[] Beds => beds;

        protected Department() : this(0, "", null, 10) { }
        protected Department(int departmentId) : this(departmentId, "", null, 10) { }
        protected Department(int departmentId, string name) : this(departmentId, name, null, 10) { }
        protected Department(int departmentId, string name, Doctor headOfDepartment, int bedCount)
        {
            this.departmentId = departmentId;
            Name = name;
            HeadOfDepartment = headOfDepartment;
            doctors = new List<Doctor>();
            beds = new bool[bedCount];
            for (int i = 0; i < bedCount; i++) beds[i] = true;
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
            NotifyDoctors($"В отделение принят новый врач: {doctor.FirstName.Capitalize()} {doctor.LastName.Capitalize()}");
        }

        public bool RemoveDoctor(int doctorId)
        {
            var d = FindDoctor(doctorId);
            if (d != null)
            {
                bool removed = doctors.Remove(d);
                if (removed) NotifyDoctors($"Врач {d.FirstName.Capitalize()} {d.LastName.Capitalize()} покинул отделение");
                return removed;
            }
            return false;
        }

        public Doctor FindDoctor(int doctorId) => doctors.Find(d => d.DoctorId == doctorId);

        public int GetAvailableBeds()
        {
            int count = 0;
            foreach (bool b in beds) if (b) count++;
            return count;
        }

        protected void NotifyDoctors(string message)
        {
            foreach (var d in doctors)
                Console.WriteLine($"Уведомление для доктора {d.FirstName.Capitalize()} {d.LastName.Capitalize()} из отделения {Name}: {message}");
        }

        public void AdmitPatient(Patient patient)
            => NotifyDoctors($"Поступил новый пациент: {patient.FirstName.Capitalize()} {patient.LastName.Capitalize()}");

        public void UpdateTreatmentProtocol(string protocolName)
            => NotifyDoctors($"Обновлён протокол лечения {protocolName}");

        public void AnnounceMeeting(DateTime when, string topic)
            => NotifyDoctors($"Назначено собрание {when:dd.MM.yyyy HH:mm}, тема: {topic}");

        public abstract string GetDepartmentReport();
        public abstract void SpecializedFunctionality();
    }

    public class Cardiology : Department
    {
        public Cardiology() : base() { }
        public Cardiology(int departmentId) : base(departmentId) { }
        public Cardiology(int departmentId, string name) : base(departmentId, name) { }
        public Cardiology(int departmentId, string name, Doctor headOfDepartment, int bedCount)
            : base(departmentId, name, headOfDepartment, bedCount) { }

        public override string GetDepartmentReport()
        {
            int patientCount = 0;
            foreach (var d in Doctors) patientCount += d.GetPatientCount();
            return $"Отчёт по кардиологическому отделению '{Name}':\n" +
                   $"  Количество врачей: {Doctors.Count}\n" +
                   $"  Количество пациентов: {patientCount}\n" +
                   $"  Свободных коек: {GetAvailableBeds()} из {Beds.Length}";
        }

        public override void SpecializedFunctionality()
        {
            Console.WriteLine("Рекомендации по профилактике сердечных заболеваний:");
            Console.WriteLine("  - регулярно измеряйте артериальное давление;");
            Console.WriteLine("  - откажитесь от курения и алкоголя;");
            Console.WriteLine("  - занимайтесь умеренной физической активностью;");
            Console.WriteLine("  - снижайте уровень стресса;");
            Console.WriteLine("  - следите за уровнем холестерина.");
        }
    }

    public class Surgery : Department
    {
        public Surgery() : base() { }
        public Surgery(int departmentId) : base(departmentId) { }
        public Surgery(int departmentId, string name) : base(departmentId, name) { }
        public Surgery(int departmentId, string name, Doctor headOfDepartment, int bedCount)
            : base(departmentId, name, headOfDepartment, bedCount) { }

        public override string GetDepartmentReport()
        {
            int patientCount = 0;
            foreach (var d in Doctors) patientCount += d.GetPatientCount();
            return $"Отчёт по хирургическому отделению '{Name}':\n" +
                   $"  Количество хирургов: {Doctors.Count}\n" +
                   $"  Количество пациентов: {patientCount}\n" +
                   $"  Свободных коек: {GetAvailableBeds()} из {Beds.Length}";
        }

        public override void SpecializedFunctionality()
        {
            Console.WriteLine("Подготовка к плановой операции:");
            Console.WriteLine("  - сдать общий анализ крови и мочи;");
            Console.WriteLine("  - выполнить ЭКГ и флюорографию;");
            Console.WriteLine("  - воздержаться от еды за 8 часов до операции;");
            Console.WriteLine("  - предупредить о принимаемых препаратах и аллергиях.");
        }
    }

    public class Therapeutic : Department
    {
        public Therapeutic() : base() { }
        public Therapeutic(int departmentId) : base(departmentId) { }
        public Therapeutic(int departmentId, string name) : base(departmentId, name) { }
        public Therapeutic(int departmentId, string name, Doctor headOfDepartment, int bedCount)
            : base(departmentId, name, headOfDepartment, bedCount) { }

        public override string GetDepartmentReport()
        {
            int patientCount = 0;
            foreach (var d in Doctors) patientCount += d.GetPatientCount();
            return $"Отчёт по терапевтическому отделению '{Name}':\n" +
                   $"  Количество терапевтов: {Doctors.Count}\n" +
                   $"  Количество пациентов: {patientCount}\n" +
                   $"  Свободных коек: {GetAvailableBeds()} из {Beds.Length}";
        }

        public override void SpecializedFunctionality()
        {
            Console.WriteLine("Общие рекомендации терапевтического отделения:");
            Console.WriteLine("  - своевременно проходите диспансеризацию;");
            Console.WriteLine("  - делайте сезонные прививки;");
            Console.WriteLine("  - укрепляйте иммунитет витаминами и полноценным сном;");
            Console.WriteLine("  - при первых симптомах ОРВИ обращайтесь к врачу.");
        }
    }

    public class Hospital : IStorable
    {
        public const int MAX_DEPARTMENTS = 10;
        private static int hospitalCount = 0;

        private int hospitalId;
        private string name;
        private string address;
        private List<Department> departments;

        public int HospitalId { get => hospitalId; set => hospitalId = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public List<Department> Departments => departments;

        public Hospital() : this(0, "", "") { }
        public Hospital(int hospitalId) : this(hospitalId, "", "") { }
        public Hospital(int hospitalId, string name) : this(hospitalId, name, "") { }
        public Hospital(int hospitalId, string name, string address)
        {
            this.hospitalId = hospitalId;
            Name = name;
            Address = address;
            departments = new List<Department>();
            hospitalCount++;
        }
        public static int GetTotalHospitals() => hospitalCount;
        public void AddDepartment(Department department)
        {
            if (departments.Count >= MAX_DEPARTMENTS)
            {
                Console.WriteLine($"Нельзя добавить новое отделение в больницу '{Name}': достигнут лимит ({MAX_DEPARTMENTS}).");
                return;
            }
            departments.Add(department);
        }

        public bool RemoveDepartment(int departmentId)
        {
            var d = departments.Find(x => x.DepartmentId == departmentId);
            if (d != null) return departments.Remove(d);
            return false;
        }
        public void SaveToFile(string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                sw.WriteLine(hospitalId);
                sw.WriteLine(name);
                sw.WriteLine(address);
                sw.WriteLine(departments.Count);
                foreach (var d in departments)
                {
                    sw.WriteLine(d.GetType().Name);
                    sw.WriteLine(d.DepartmentId);
                    sw.WriteLine(d.Name);
                    sw.WriteLine(d.Beds.Length);
                }
            }
        }

        public void LoadFromFile(string filePath)
        {
            using (var sr = new StreamReader(filePath))
            {
                hospitalId = int.Parse(sr.ReadLine());
                name = sr.ReadLine();
                address = sr.ReadLine();
                int count = int.Parse(sr.ReadLine());
                departments = new List<Department>();
                for (int i = 0; i < count; i++)
                {
                    string type = sr.ReadLine();
                    int did = int.Parse(sr.ReadLine());
                    string dname = sr.ReadLine();
                    int bedCount = int.Parse(sr.ReadLine());
                    Department dep = type switch
                    {
                        "Cardiology" => new Cardiology(did, dname, null, bedCount),
                        "Surgery" => new Surgery(did, dname, null, bedCount),
                        "Therapeutic" => new Therapeutic(did, dname, null, bedCount),
                        _ => null
                    };
                    if (dep != null) departments.Add(dep);
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Пишите проверки сами, я вам не дам всё на блюдечке)
        }
    }
}
