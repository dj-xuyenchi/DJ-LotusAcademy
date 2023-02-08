import NotFount from '../component/Error/NotFount';
import EvaluteStudent from '../component/Business/StudentManager/Evalute/EvaluteStudent';
const routes = [
    { path: '/student', element: <EvaluteStudent /> },
    { path: '*', element: <NotFount /> },
];
export default routes;
