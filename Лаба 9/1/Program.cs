namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пишите проверки сами, я вам не дам всё на блюдечке)
        }
        public class Patient
        {
            private readonly int patientId;
            private string firstName;
            private string lastName;
            private DateTime dateOfBirth;
            private string diagnosis;
            public int PatientId => patientId;
            public string FirstName { get => firstName; set => firstName = value; }
            public string LastName { get => lastName; set => lastName = value; }
            public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
            public string Diagnosis { get => diagnosis; set => diagnosis = value; }
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
            public override string ToString() => $"{FirstName} {LastName}, возраст {GetAge()}, диагноз: {Diagnosis}";
        }

        public class Doctor
        {
            private readonly int doctorId;
            private string firstName;
            private string lastName;
            private string specialization;
            private List<Patient> patients;
            public int DoctorId => doctorId;
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
            public bool RemovePatient(int patientId)
            {
                var p = FindPatient(patientId);
                if (p != null) return patients.Remove(p);
                return false;
            }
            public Patient FindPatient(int patientId) => patients.Find(p => p.PatientId == patientId);
            public int GetPatientCount() => patients.Count;
        }
        public class Cardiology
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
            public Cardiology() : this(0, "", null, 10) { }
            public Cardiology(int departmentId) : this(departmentId, "", null, 10) { }
            public Cardiology(int departmentId, string name) : this(departmentId, name, null, 10) { }
            public Cardiology(int departmentId, string name, Doctor headOfDepartment, int bedCount)
            {
                this.departmentId = departmentId;
                Name = name;
                HeadOfDepartment = headOfDepartment;
                doctors = new List<Doctor>();
                beds = new bool[bedCount];
                for (int i = 0; i < bedCount; i++) beds[i] = true;
            }
            public void AddDoctor(Doctor doctor) => doctors.Add(doctor);
            public bool RemoveDoctor(int doctorId)
            {
                var d = FindDoctor(doctorId);
                if (d != null) return doctors.Remove(d);
                return false;
            }
            public Doctor FindDoctor(int doctorId) => doctors.Find(d => d.DoctorId == doctorId);
            public int GetAvailableBeds()
            {
                int count = 0;
                foreach (bool b in beds) if (b) count++;
                return count;
            }
        }
        public class Surgery
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
            public Surgery() : this(0, "", null, 10) { }
            public Surgery(int departmentId) : this(departmentId, "", null, 10) { }
            public Surgery(int departmentId, string name) : this(departmentId, name, null, 10) { }
            public Surgery(int departmentId, string name, Doctor headOfDepartment, int bedCount)
            {
                this.departmentId = departmentId;
                Name = name;
                HeadOfDepartment = headOfDepartment;
                doctors = new List<Doctor>();
                beds = new bool[bedCount];
                for (int i = 0; i < bedCount; i++) beds[i] = true;
            }
            public void AddDoctor(Doctor doctor) => doctors.Add(doctor);
            public bool RemoveDoctor(int doctorId)
            {
                var d = FindDoctor(doctorId);
                if (d != null) return doctors.Remove(d);
                return false;
            }
            public Doctor FindDoctor(int doctorId) => doctors.Find(d => d.DoctorId == doctorId);
            public int GetAvailableBeds()
            {
                int count = 0;
                foreach (bool b in beds) if (b) count++;
                return count;
            }
        }
        public class Therapeutic
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
            public Therapeutic() : this(0, "", null, 10) { }
            public Therapeutic(int departmentId) : this(departmentId, "", null, 10) { }
            public Therapeutic(int departmentId, string name) : this(departmentId, name, null, 10) { }
            public Therapeutic(int departmentId, string name, Doctor headOfDepartment, int bedCount)
            {
                this.departmentId = departmentId;
                Name = name;
                HeadOfDepartment = headOfDepartment;
                doctors = new List<Doctor>();
                beds = new bool[bedCount];
                for (int i = 0; i < bedCount; i++) beds[i] = true;
            }
            public void AddDoctor(Doctor doctor) => doctors.Add(doctor);
            public bool RemoveDoctor(int doctorId)
            {
                var d = FindDoctor(doctorId);
                if (d != null) return doctors.Remove(d);
                return false;
            }
            public Doctor FindDoctor(int doctorId) => doctors.Find(d => d.DoctorId == doctorId);
            public int GetAvailableBeds()
            {
                int count = 0;
                foreach (bool b in beds) if (b) count++;
                return count;
            }
        }
        public class Hospital
        {
            private readonly int hospitalId;
            private string name;
            private string address;
            private List<int> departments;

            public int HospitalId => hospitalId;
            public string Name { get => name; set => name = value; }
            public string Address { get => address; set => address = value; }
            public List<int> Departments => departments;

            public Hospital(int hospitalId) : this(hospitalId, "", "") { }
            public Hospital(int hospitalId, string name) : this(hospitalId, name, "") { }
            public Hospital(int hospitalId, string name, string address)
            {
                this.hospitalId = hospitalId;
                Name = name;
                Address = address;
                departments = new List<int>();
            }
        }
    }
}