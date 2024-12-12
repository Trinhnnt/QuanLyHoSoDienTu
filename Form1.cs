using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HoSoDienTu
{
    public partial class Form1 : Form
    {
        private BinaryTree employeeTree;
        public Form1()
        {
            InitializeComponent();
            employeeTree = new BinaryTree();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        public class Node
        {
            public int ID { get; set; }
            public string EName { get; set; }
            public string Position { get; set; }
            public string Gender { get; set; }
            public DateTime Timestamp { get; set; }
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }

            public Node(int id, string name, string position, string gender, DateTime timestamp)
            {
                ID = id;
                EName = name;
                Position = position;
                Gender = gender;
                Timestamp = timestamp;
                LeftNode = null;
                RightNode = null;
            }
        }
        public class BinaryTree
        {
            public Node Root { get; set; }

            public BinaryTree()
            {
                Root = null;
            }

            public void Insert(int id, string name, string position, string gender, DateTime timestamp)
            {
                Root = InsertRec(Root, id, name, position, gender, timestamp);
            }

            private Node InsertRec(Node root, int id, string name, string position, string gender, DateTime timestamp)
            {
                if (root == null)
                {
                    return new Node(id, name, position, gender, timestamp);
                }

                if (timestamp < root.Timestamp)
                {
                    root.LeftNode = InsertRec(root.LeftNode, id, name, position, gender, timestamp);
                }
                else if (timestamp > root.Timestamp)
                {
                    root.RightNode = InsertRec(root.RightNode, id, name, position, gender, timestamp);
                }

                return root;
            }

            public void Delete(int id)
            {
                Root = DeleteRec(Root, id);
            }

            private Node DeleteRec(Node root, int id)
            {
                if (root == null) return root;

                if (id < root.ID)
                {
                    root.LeftNode = DeleteRec(root.LeftNode, id);
                }
                else if (id > root.ID)
                {
                    root.RightNode = DeleteRec(root.RightNode, id);
                }
                else
                {
                    if (root.LeftNode == null)
                        return root.RightNode;
                    if (root.RightNode == null)
                        return root.LeftNode;

                    root.ID = FindMin(root.RightNode).ID;
                    root.RightNode = DeleteRec(root.RightNode, root.ID);
                }
                return root;
            }

            public Node FindMin(Node root)
            {
                while (root.LeftNode != null)
                    root = root.LeftNode;
                return root;
            }

            public List<Node> SearchByName(string name)
            {
                List<Node> result = new List<Node>();
                SearchByNameRec(Root, name, result);
                return result;
            }

            private void SearchByNameRec(Node root, string name, List<Node> result)
            {
                if (root != null)
                {
                    SearchByNameRec(root.LeftNode, name, result);
                    if (root.EName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result.Add(root);
                    }
                    SearchByNameRec(root.RightNode, name, result);
                }
            }

            public List<Node> SearchByTimeRange(DateTime start, DateTime end)
            {
                List<Node> result = new List<Node>();
                SearchByTimeRangeRec(Root, start, end, result);
                return result;
            }

            private void SearchByTimeRangeRec(Node root, DateTime start, DateTime end, List<Node> result)
            {
                if (root == null)
                    return;

                
                if (root.Timestamp.Date >= start.Date && root.Timestamp.Date <= end.Date)
                {
                    result.Add(root); 
                }

                
                if (root.Timestamp > start)
                {
                    SearchByTimeRangeRec(root.LeftNode, start, end, result);
                }

                
                if (root.Timestamp < end)
                {
                    SearchByTimeRangeRec(root.RightNode, start, end, result);
                }
            }

            public int CountNodes(Node root)
            {
                if (root == null) return 0;
                return 1 + CountNodes(root.LeftNode) + CountNodes(root.RightNode);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện
                int id = int.Parse(txtID.Text);
                string name = txtName.Text.Trim();
                string position = txtPosition.Text.Trim();
                string gender = cbGender.SelectedItem.ToString();
                DateTime timestamp = dtpTimestamp.Value;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm nhân viên vào cây nhị phân
                employeeTree.Insert(id, name, position, gender, timestamp);

                // Thông báo thêm thành công
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");

                // Cập nhật lại giao diện DataGridView
                UpdateGridView();

                // Xóa dữ liệu trong các TextBox
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã nhân viên từ TextBox
                if (int.TryParse(txtDeleteID.Text, out int maNhanVien))
                {
                    // Gọi hàm xóa trong BinaryTree
                    employeeTree.Delete(maNhanVien);

                    // Cập nhật lại DataGridView sau khi xóa
                    MessageBox.Show("Nhân viên đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGridView();
                    ClearInputs(); // Xóa các trường nhập liệu
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNhanVien = txtSearchName.Text.Trim(); // Lấy tên nhập từ TextBox

                if (string.IsNullOrEmpty(tenNhanVien))
                {
                    MessageBox.Show("Vui lòng nhập tên để tìm kiếm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tìm kiếm nhân viên theo tên
                var ketQuaTimKiem = employeeTree.SearchByName(tenNhanVien);

                // Hiển thị kết quả lên DataGridView
                UpdateGridView(ketQuaTimKiem);

                ClearInputs();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchByTime_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpStartTime.Value; // Lấy ngày bắt đầu từ DateTimePicker
                DateTime endDate = dtpEndTime.Value; // Lấy ngày kết thúc từ DateTimePicker

                if (startDate > endDate)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tìm kiếm nhân viên theo khoảng thời gian
                var ketQuaTimKiem = employeeTree.SearchByTimeRange(startDate, endDate);

                // Hiển thị kết quả lên DataGridView
                UpdateGridView(ketQuaTimKiem);

                ClearInputs();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị toàn bộ cây nhị phân lên DataGridView
                UpdateGridView();

                // Cập nhật tổng số nhân viên
                int totalEmployees = employeeTree.CountNodes(employeeTree.Root);
                lblTotalEmployees.Text = $"Tổng số nhân viên: {totalEmployees}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateGridView(List<Node> nodes = null)
        {
            dgvData.Rows.Clear();

            if (nodes == null) // Hiển thị toàn bộ cây
            {
                AddNodesToGrid(employeeTree.Root);
            }
            else // Hiển thị kết quả tìm kiếm
            {
                foreach (var node in nodes)
                {
                    dgvData.Rows.Add(node.ID, node.EName, node.Gender, node.Position, node.Timestamp.ToString("dd/MM/yyyy"));
                }
            }
        }

        private void AddNodesToGrid(Node root)
        {
            if (root != null)
            {
                AddNodesToGrid(root.LeftNode); // Thêm các nút bên trái
                dgvData.Rows.Add(root.ID, root.EName, root.Gender, root.Position, root.Timestamp.ToString("dd/MM/yyyy")); // Thêm nút hiện tại
                AddNodesToGrid(root.RightNode); // Thêm các nút bên phải
            }
        }
        private void UpdateGridView()
        {
            dgvData.Rows.Clear();
            AddNodesToGrid(employeeTree.Root);
        }

        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtPosition.Clear();
            txtDeleteID.Clear();
            txtSearchName.Clear();
            cbGender.SelectedIndex = -1; // Bỏ chọn ComboBox
            dtpTimestamp.Value = DateTime.Now; // Đặt lại ngày hiện tại
            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now;    
        }

        
    }
}
