import React from 'react';
import Header from './Header';
//import Sidebar from './Sidebar';
import CourseContent from './CourseContent';
import Footer from './Footer';
import './CourseDetailsTeacher.css';
import HeaderSidebar from 'D:/IeltsWeb/ReactFE/src/coursedetails/HeaderSidebar.jsx';

const CourseDetailsTeacher = () => {
  return (
    <div className="course-details">
      <Header />
      <main className="course-main">
        <HeaderSidebar />
        <CourseContent />
      </main>
      <Footer />
    </div>
  );
};

export default CourseDetailsTeacher;