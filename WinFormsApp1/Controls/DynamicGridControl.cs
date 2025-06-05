using System;
using System.ComponentModel;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controls
{
    public partial class DynamicGridControl : UserControl
    {
        // The model that will be used for data binding
        private GridSettingsModel _model;

       
        public GridSettingsModel Model
        {
            get => _model;
            set
            {
                // Unsubscribe from the old model's events
                if (_model != null)
                    _model.PropertyChanged -= Model_PropertyChanged;
                
                _model = value;
                
                // Subscribe to the new model's events
                if (_model != null)
                {
                    _model.PropertyChanged += Model_PropertyChanged;
                    UpdateBindings();
                }
            }
        }

      
        public DynamicGridControl()
        {
            InitializeComponent();

            // Create a new model
            _model = new GridSettingsModel();
            
            // Set up data bindings
            SetupDataBindings();
            
            // Subscribe to model property changes
            _model.PropertyChanged += Model_PropertyChanged;
            
            // Ensure textboxes are empty on initialization
            textBoxRows.Text = string.Empty;
            textBoxColumns.Text = string.Empty;
        }

       
        private void SetupDataBindings()
        {
            // Bind the textboxes to the model properties
            textBoxRows.DataBindings.Add("Text", _model, "Rows", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxColumns.DataBindings.Add("Text", _model, "Columns", true, DataSourceUpdateMode.OnPropertyChanged);
        }

       
        private void UpdateBindings()
        {
            // Clear existing bindings
            textBoxRows.DataBindings.Clear();
            textBoxColumns.DataBindings.Clear();
            
            // Set up new bindings
            SetupDataBindings();
        }

        private void Model_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            // Update the grid when rows or columns change
            if (e.PropertyName == nameof(GridSettingsModel.Rows) || 
                e.PropertyName == nameof(GridSettingsModel.Columns))
            {
                UpdateGrid();
            }
        }

        private void UpdateGrid()
        {
            try
            {
                // Clear existing grid
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                // Add columns based on model
                for (int i = 0; i < _model.Columns; i++)
                {
                    dataGridView1.Columns.Add($"col{i}", $"Column {i+1}");
                }

                // Add rows based on model
                for (int i = 0; i < _model.Rows; i++)
                {
                    dataGridView1.Rows.Add();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating grid: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
        public int Rows
        {
            get => _model.Rows;
            set => _model.Rows = value;
        }
        
        public int Columns
        {
            get => _model.Columns;
            set => _model.Columns = value;
        }
    }
}