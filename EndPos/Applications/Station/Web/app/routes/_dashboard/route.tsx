import { PropsWithChildren } from "react";
import { Layout } from "antd";
import { Outlet } from "react-router";

export default function DashboardLayout() {
  return (
    <Layout className="h-full">
      <Layout.Header>Header</Layout.Header>
      <Outlet />
    </Layout>
  );
}
