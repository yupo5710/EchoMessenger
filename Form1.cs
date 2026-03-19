namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelEchoMessenger_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)

        {
            if (txtMessege.Text.Length > 50)
            {
                MessageBox.Show("메시지는 50자를 넘길 수 없습니다.");
                txtMessege.Text = txtMessege.Text.Substring(0, 50);
                txtMessege.SelectionStart = txtMessege.Text.Length; // 커서 맨 뒤로 이동
            }

            if (!string.IsNullOrWhiteSpace(txtMessege.Text))
            {
                string timeStamp = DateTime.Now.ToString("HH:mm:ss"); //현재 시간을 "HH:mm:ss" 형식으로 문자열로 변환하여 timeStamp 변수에 저장
                string TrimMessege = txtMessege.Text.Trim(); //텍스트 박스에서 입력된 메시지의 앞뒤 공백을 제거하여 TrimMessege 변수에 저장
                string typedMsg = $"[{timeStamp}] {TrimMessege}"; // 시간과 메시지를 함께 표시
                lbChatLog.Items.Add(typedMsg); //result 변수를 채팅 로그 리스트 박스에 추가하여 메시지를 표시
                txtMessege.Clear(); //텍스트 박스의 내용을 지워서 다음 메시지를 입력할 수 있도록 준비
                txtMessege.Focus(); //채팅 이동후 커서가 다시 채팅 입력창 이동

                lblCount.Text = $"메세지 수 : {lbChatLog.Items.Count}개";
            }
        }

        private void lbChatLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMessege_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessege_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnSend.PerformClick(); //btnSend 버튼의 클릭 이벤트를 트리거하여 메시지를 전송하는 기능을 재사용
                e.SuppressKeyPress = true; //줄바꿈 방지

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCount.Text = "메세지 수 : 0개"; //처음 작동할때 메세지 수 0개로 초기화
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //메세지 삭제 기능
            if (lbChatLog.SelectedIndex != -1)
            {
                lbChatLog.Items.RemoveAt(lbChatLog.SelectedIndex);

                // 메시지 수 업데이트
                lblCount.Text = $"메세지 수 : {lbChatLog.Items.Count}개";
            }
            else
            {
                MessageBox.Show("삭제할 메시지를 선택하세요.");
            }

        }

        private void btnAllDelete_Click(object sender, EventArgs e)
        {
            lbChatLog.Items.Clear();
            lblCount.Text = "메세지 수 : 0개";
        }
    }
}
