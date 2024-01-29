import React, { ReactElement, FC, useEffect, useState } from "react";
import {
  Card,
  CardContent,
  CircularProgress,
  Container,
  Grid,
  Typography,
} from "@mui/material";
import * as resourceApi from "../../api/modules/resources";
import { IResource } from "../../interfaces/resources";

const ResourcesList: FC = (): ReactElement => {
  const [resources, setResources] = useState<IResource[]>([]);
  const [isLoading, setIsLoading] = useState<boolean>(false);

  useEffect(() => {
    const fetchResources = async () => {
      try {
        setIsLoading(true);
        const res = await resourceApi.getAll();
        setResources(res.data);
      } catch (e) {
        if (e instanceof Error) {
          console.error(e.message);
        }
      }
      setIsLoading(false);
    };
    fetchResources();
  }, []);

  return (
    <Container>
      <Grid container spacing={4}>
        {isLoading ? (
          <CircularProgress />
        ) : (
          resources.map((resource) => (
            <Grid item key={resource.id} xs={12} sm={6} md={4} lg={3}>
              <Card sx={{ maxWidth: 250 }}>
                <CardContent>
                  <Typography noWrap gutterBottom variant="h6" component="div">
                    {resource.name}
                  </Typography>
                  <Typography variant="body2" color="text.secondary">
                    ID: {resource.id}
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

export default ResourcesList;
