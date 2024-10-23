<telerik:RadGridView ItemsSource="{Binding Pipelines}" AutoGenerateColumns="False">
    <telerik:RadGridView.Columns>
        <!--  -->
        <telerik:GridViewDataColumn Header="Property" Width="200">
            <telerik:GridViewDataColumn.CellTemplate>
                <DataTemplate>
                    <!-- -->
                    <ContentControl Content="{Binding}">
                        <ContentControl.Style>
                            <Style TargetType="ContentControl">
                                <Style.Triggers>
                                    <!-- -->
                                    <DataTrigger Binding="{Binding IsDropdown}" Value="True">
                                        <Setter Property="ContentTemplate">
                                            <Setter.Value>
                                                <DataTemplate>
                                                    <ComboBox ItemsSource="{Binding Values}" 
                                                              SelectedItem="{Binding Value, Mode=TwoWay}" />
                                                </DataTemplate>
                                            </Setter.Value>
                                        </Setter>
                                    </DataTrigger>

                                    <!--  -->
                                    <DataTrigger Binding="{Binding IsDropdown}" Value="False">
                                        <Setter Property="ContentTemplate">
                                            <Setter.Value>
                                                <DataTemplate>
                                                    <TextBlock Text="{Binding Value}" />
                                                </DataTemplate>
                                            </Setter.Value>
                                        </Setter>
                                    </DataTrigger>
                                </Style.Triggers>
                            </Style>
                        </ContentControl.Style>
                    </ContentControl>
                </DataTemplate>
            </telerik:GridViewDataColumn.CellTemplate>

            <!--  -->
            <telerik:GridViewDataColumn.CellEditTemplate>
                <DataTemplate>
                    <ContentControl Content="{Binding}">
                        <ContentControl.Style>
                            <Style TargetType="ContentControl">
                                <Style.Triggers>
                                    <!---->
                                    <DataTrigger Binding="{Binding IsDropdown}" Value="True">
                                        <Setter Property="ContentTemplate">
                                            <Setter.Value>
                                                <DataTemplate>
                                                    <ComboBox ItemsSource="{Binding Values}" 
                                                              SelectedItem="{Binding Value, Mode=TwoWay}" />
                                                </DataTemplate>
                                            </Setter.Value>
                                        </Setter>
                                    </DataTrigger>

                                    <!-- -->
                                    <DataTrigger Binding="{Binding IsDropdown}" Value="False">
                                        <Setter Property="ContentTemplate">
                                            <Setter.Value>
                                                <DataTemplate>
                                                    <TextBox Text="{Binding Value, Mode=TwoWay}" />
                                                </DataTemplate>
                                            </Setter.Value>
                                        </Setter>
                                    </DataTrigger>
                                </Style.Triggers>
                            </Style>
                        </ContentControl.Style>
                    </ContentControl>
                </DataTemplate>
            </telerik:GridViewDataColumn.CellEditTemplate>
        </telerik:GridViewDataColumn>
    </telerik:RadGridView.Columns>
</telerik:RadGridView>
