import { Layout } from 'antd';
import { Content, Header } from 'antd/es/layout/layout';

const Home = () => {
    return (
        <Layout className="bg-white">
            <Header className=" d-flex items-center">
                <h3 className="m-0">Bảng tin</h3>
            </Header>
            <Content className=" mb-[20px] mx-[20px]">
                <div className="row h-100 gx-3">
                    <div className="col-lg-9">
                        <div className="bg-slate-200 h-100 p-3 rounded-xl"></div>
                    </div>
                    <div className="col-lg-3">
                        <div className="row h-100">
                            <div className="col-12 ">
                                <div className="bg-slate-200 rounded-xl h-100 p-3"></div>
                            </div>
                            <div className="col-12 mt-3">
                                <div className="bg-slate-200 rounded-xl h-100 p-3"></div>
                            </div>
                            <div className="col-12 mt-3">
                                <div className="bg-slate-200 rounded-xl h-100 p-3"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </Content>
        </Layout>
    );
};

export default Home;
