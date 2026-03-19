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
            if (!string.IsNullOrWhiteSpace(txtMessege.Text))
            {
                string msg = txtMessege.Text; //텍스트 박스에서 입력된 메시지를 가져온 후 result 변수에 저장
                lbChatLog.Items.Add(msg); //result 변수를 채팅 로그 리스트 박스에 추가하여 메시지를 표시
                txtMessege.Clear(); //텍스트 박스의 내용을 지워서 다음 메시지를 입력할 수 있도록 준비
                txtMessege.Focus(); //채팅 이동후 커서가 다시 채팅 입력창 이동
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
    }
}
