﻿namespace SCaddins.ModelSetupWizard.ViewModels
{
    using System.Collections.Specialized;
    using Caliburn.Micro;

    internal class ModelSetupWizardOptionsViewModel
    {
        public ModelSetupWizardOptionsViewModel()
        {
            DefaultWorksets = new BindableCollection<WorksetParameter>();
            ProjectInformationReplacements = new BindableCollection<ProjectInformationReplacement>();
            NominatedArchitects = new BindableCollection<NominatedArchitect>();
            Init();
        }

        public BindableCollection<WorksetParameter> DefaultWorksets
        {
            get; private set;
        }

        public string FileNameParameterName
        {
            get; set;
        }

        public string NominatedArchitectNumberParameterName
        {
            get; set;
        }

        public string NominatedArchitectParameterName
        {
            get; set;
        }

        public BindableCollection<NominatedArchitect> NominatedArchitects
        {
            get; private set;
        }

        public BindableCollection<ProjectInformationReplacement> ProjectInformationReplacements
        {
            get; private set;
        }

        public WorksetParameter SelectedDefaultWorkset
        {
            get; set;
        }

        public NominatedArchitect SelectedNominatedArchitect
        {
            get; set;
        }

        public ProjectInformationReplacement SelectedProjectInformationReplacement
        {
            get; set;
        }

        public void AddArchitect()
        {
            NominatedArchitects.Add(new NominatedArchitect(string.Empty, string.Empty));
        }

        public void AddReplacement()
        {
            ProjectInformationReplacements.Add(new ProjectInformationReplacement());
        }

        public void AddWorksets()
        {
            DefaultWorksets.Add(new WorksetParameter());
        }

        public void Apply()
        {
            var sc = new StringCollection();
            foreach (var s in ProjectInformationReplacements)
            {
                sc.Add(s.ToString());
            }
            ModelSetupWizardSettings.Default.DefaultProjectInformation = sc;

            var wsc = new StringCollection();
            foreach (var w in DefaultWorksets)
            {
                wsc.Add(w.ToString());
            }

            ModelSetupWizardSettings.Default.DefaultWorksets = wsc;

            var arch = new StringCollection();
            foreach (var a in NominatedArchitects)
            {
                arch.Add(a.ToString());
            }

            ModelSetupWizardSettings.Default.DefaultArchitectInformation = arch;

            ModelSetupWizardSettings.Default.NomArchitectParamName = NominatedArchitectParameterName;
            ModelSetupWizardSettings.Default.NomArchitectNoumberParamName = NominatedArchitectNumberParameterName;
            ModelSetupWizardSettings.Default.FileNameParameterName = FileNameParameterName;

            ModelSetupWizardSettings.Default.Save();
        }

        public void ExportConfig()
        {
            string filePath = string.Empty;
            SCaddinsApp.WindowManager.ShowSaveFileDialog(@"config.xml", "*.xml", "XML |*.xml", out filePath);
            SettingsIO.Export(filePath);
        }

        public void ImportConfig()
        {
            string filePath = string.Empty;
            bool? result = SCaddinsApp.WindowManager.ShowOpenFileDialog(string.Empty, out filePath);
            if (result.HasValue && result.Value == true && System.IO.File.Exists(filePath))
            {
                SettingsIO.Import(filePath);
                Reset();
            }
        }

        public void RemoveArchitect()
        {
            NominatedArchitects.Remove(SelectedNominatedArchitect);
        }

        public void RemoveReplacement()
        {
            ProjectInformationReplacements.Remove(SelectedProjectInformationReplacement);
        }

        public void RemoveWorksets()
        {
            DefaultWorksets.Remove(SelectedDefaultWorkset);
        }

        public void Reset()
        {
            DefaultWorksets.Clear();
            ProjectInformationReplacements.Clear();
            NominatedArchitects.Clear();
            Init();
        }

        private void AddDefaultWorksets()
        {
            var newWorksets = ModelSetupWizardSettings.Default.DefaultWorksets;
            foreach (var newWorksetDef in newWorksets)
            {
                var segs = newWorksetDef.Split(';');
                int b = 0;
                var r = int.TryParse(segs[1].Trim(), out b);
                if (!string.IsNullOrEmpty(segs[0]))
                {
                    if (segs.Length > 2 && !string.IsNullOrEmpty(segs[2]))
                    {
                        WorksetParameter wp = new WorksetParameter(segs[0], b != 0, segs[2]);
                        DefaultWorksets.Add(wp);
                    }
                    else
                    {
                        WorksetParameter wp = new WorksetParameter(segs[0], b != 0, -1);
                        DefaultWorksets.Add(wp);
                    }
                }
            }
        }

        private void AddNominatedArchitects()
        {
            var architects = ModelSetupWizardSettings.Default.DefaultArchitectInformation;
            foreach (var architect in architects)
            {
                var segs = architect.Split(';');
                if (segs.Length == 2 && !string.IsNullOrEmpty(segs[0]) && !string.IsNullOrEmpty(segs[1]))
                {
                    NominatedArchitects.Add(new NominatedArchitect(segs[0].Trim(), segs[1].Trim()));
                }
            }
        }

        private void AddProjectInformationReplacements()
        {
            var pinf = ModelSetupWizardSettings.Default.DefaultProjectInformation;
            foreach (var p in pinf)
            {
                var segs = p.Split(';');
                if (segs.Length > 1)
                {
                    ProjectInformationReplacement wp = new ProjectInformationReplacement(segs[0], segs[1]);
                    ProjectInformationReplacements.Add(wp);
                    if (segs.Length > 2)
                    {
                        wp.ReplacementFormat = segs[2];
                    }
                }
            }
        }

        private void Init()
        {
            AddDefaultWorksets();
            AddProjectInformationReplacements();
            AddNominatedArchitects();
            NominatedArchitectParameterName = ModelSetupWizardSettings.Default.NomArchitectParamName;
            NominatedArchitectNumberParameterName = ModelSetupWizardSettings.Default.NomArchitectNoumberParamName;
            FileNameParameterName = ModelSetupWizardSettings.Default.FileNameParameterName;
        }
    }
}
