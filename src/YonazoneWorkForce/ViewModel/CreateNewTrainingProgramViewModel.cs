using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonazoneWorkForce.Models;
using YonazoneWorkForce.ViewModels;

namespace YonazoneWorkForce.ViewModels
{
    public class CreateNewTrainingProgramViewModel : BaseViewModel
    {

        public List<TrainingProgram> TrainingPrograms { get; set; }

        public TrainingProgram TrainingProgram { get; set; }

        public CreateNewTrainingProgramViewModel() { }

        public CreateNewTrainingProgramViewModel(TrainingProgram TrainingProgram) { }
    }
}
