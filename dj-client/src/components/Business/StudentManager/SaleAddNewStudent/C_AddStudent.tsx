import { Modal } from 'antd';
import { useState } from 'react';
function C_AddNewStudent() {
    const [isModalOpen, setIsModalOpen] = useState(false);
    const showModal = () => {
        setIsModalOpen(true);
    };
    const handleCancel = () => {
        setIsModalOpen(false);
    };
    return (
        <div>
            <h1>Thêm học viên</h1>

            <button className="btn btn-primary" onClick={showModal}>
                Add New User
            </button>

            <Modal title="Basic Modal" open={isModalOpen} onCancel={handleCancel}>
                <p>Some contents...</p>
                <p>Some contents...</p>
                <p>Some contents...</p>
            </Modal>
        </div>
    );
}

export default C_AddNewStudent;
