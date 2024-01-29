import React, { ReactElement, FC, useEffect, useState } from "react";
import {
  Card,
  CardContent,
  CardMedia,
  CircularProgress,
  Container,
  Grid,
  Typography,
} from "@mui/material";
import * as userApi from "../../api/modules/users";
import { IUser } from "../../interfaces/users";

const UserList: FC = (): ReactElement => {
  const [users, setUsers] = useState<IUser[]>([]);
  const [isLoading, setIsLoading] = useState<boolean>(false);

  useEffect(() => {
    const fetchUsers = async () => {
      try {
        setIsLoading(true);
        const res = await userApi.getAll();
        setUsers(res.data);
      } catch (e) {
        if (e instanceof Error) {
          console.error(e.message);
        }
      }
      setIsLoading(false);
    };
    fetchUsers();
  }, []);

  return (
    <Container>
      <Grid container spacing={4}>
        {isLoading ? (
          <CircularProgress />
        ) : (
          users.map((user) => (
            <Grid item key={user.id} xs={12} sm={6} md={4} lg={3}>
              <Card sx={{ maxWidth: 250 }}>
                <CardMedia
                  component="img"
                  height="250"
                  image={user.avatar}
                  alt={user.email}
                />
                <CardContent>
                  <Typography noWrap gutterBottom variant="h6" component="div">
                    {user.email}
                  </Typography>
                  <Typography variant="body2" color="text.secondary">
                    {user.first_name} {user.last_name}
                  </Typography>
                </CardContent>
              </Card>
            </Grid>
          ))
        )}
      </Grid>
    </Container>
  );
};

export default UserList;
