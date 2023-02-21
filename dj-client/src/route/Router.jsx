import NotFound from "../components/404/NotFound";
import EvaluteStudent from "../components/Business/StudentManager/Evalute/EvaluteStudent";
import StudentDetail from "../components/Business/StudentManager/Evalute/StudentDetail/StudentDetail";
import Home from "../Layout/Home";

const Routes = [
    {
        path: "/",
        element: <Home />,
    },
    {
        path: "/hocvien",
        element: <EvaluteStudent />,
    },
    {
        path: "/hocvien/:id",
        element: <StudentDetail />,
    },

    { path: "*", element: <NotFound /> },
];

export default Routes;
